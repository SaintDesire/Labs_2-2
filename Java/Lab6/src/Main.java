import java.sql.*;
import org.apache.log4j.Logger;

public class Main {

    private static final String CREATE_BOOKS_TABLE_QUERY = "CREATE TABLE IF NOT EXISTS books (" +
            "id INT PRIMARY KEY AUTO_INCREMENT," +
            "title VARCHAR(255)," +
            "author VARCHAR(255)," +
            "year INT," +
            "producer VARCHAR(255)" +
            ");";
    private static final String CREATE_AUTHORS_TABLE_QUERY = "CREATE TABLE IF NOT EXISTS authors (" +
            "id INT PRIMARY KEY AUTO_INCREMENT," +
            "name VARCHAR(255)," +
            "country VARCHAR(255)" +
            ");";
    private static final String INSERT_BOOKS_QUERY =
            "INSERT INTO books (title, author, year, producer) VALUES (?, ?, ?, ? );";

    private static final String INSERT_AUTHORS_QUERY =
            "INSERT INTO authors (name, country) VALUES (?, ?);";

    private static final String SELECT_BOOKS_QUERY = "SELECT * FROM books WHERE year = ?;";
    private static final String SELECT_AUTHORS_QUERY = "SELECT * FROM authors;";

    private static final String DELETE_BOOKS_QUERY = "TRUNCATE TABLE books;";
    private static final String DELETE_AUTHORS_QUERY = "TRUNCATE TABLE authors;";

    private static final String SELECT_AUTHORS_BOOK_QUERY =
            "SELECT authors.name, COUNT(*) as book_count " +
                    "FROM authors JOIN books ON authors.name = books.author " +
                    "GROUP BY authors.name " +
                    "HAVING COUNT(*) > ?";

    private static final String SELECT_ALL_BOOKS =
            "SELECT * FROM books;";

    private static final String DELETE_BOOKS_BY_YEAR =
            "DELETE FROM books WHERE year > ?;";



    private static final String URL = "jdbc:mysql://localhost:3306/Library";
    private static final String USER = "root";
    private static final String PASSWORD = "root";

    private static final Logger logger = Logger.getLogger(Main.class.getName());
    public static void main(String[] args) {
        try  {
            Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
            connection.setAutoCommit(false);
            Statement statement = connection.createStatement();

            // Создаем таблицы
            Savepoint savepointOne = connection.setSavepoint("savepointOne");
            try {
                statement.executeUpdate(CREATE_AUTHORS_TABLE_QUERY);

                statement.executeUpdate(CREATE_BOOKS_TABLE_QUERY);

                connection.commit();
                logger.info("Таблицы созданы.");
            } catch (SQLException e) {
                System.out.println("SQLException. Executing rollback to savepoint...");
                connection.rollback(savepointOne);
            }

            // Функция для очистки таблиц
            DeleteData();
            logger.info("Таблицы очищены.");

            // Функции для добавления данных в таблицу books
            InsertBooksData("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Scribner");
            InsertBooksData("To Kill a Mockingbird", "Harper Lee", 1960, "J. B. Lippincott & Co.");
            InsertBooksData("The Catcher in the Rye", "J. D. Salinger", 1951, "Little, Brown and Company");
            InsertBooksData("1984", "George Orwell", 1949, "Secker & Warburg");
            InsertBooksData("Animal Farm", "George Orwell", 1945, "Secker & Warburg");
            InsertBooksData("The Hobbit", "J. R. R. Tolkien", 1937, "George Allen & Unwin");
            InsertBooksData("The Lord of the Rings", "J. R. R. Tolkien", 1954, "George Allen & Unwin");
            InsertBooksData("The Da Vinci Code", "Dan Brown", 2023, "Doubleday");
            InsertBooksData("The Girl with the Dragon Tattoo", "Stieg Larsson", 2022, "Norsted");
            InsertBooksData("Pride and Prejudice", "Jane Austen", 2022, "Thomas Egerton");
            InsertBooksData("One Hundred Years of Solitude", "Gabriel Garcia Marquez", 1967, "Harper & Row");
            InsertBooksData("War and Peace", "Lev Tolstoy", 1869, "The Russian Messenger");
            InsertBooksData("Norwegian Wood", "Haruki Murakami", 1987, "Kodansha");
            InsertBooksData("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 1997, "Bloomsbury");
            InsertBooksData("Kafka on the Shore", "Haruki Murakami", 2002, "Kodansha");
            InsertBooksData("1Q84", "Haruki Murakami", 2009, "Shinchosha");
            InsertBooksData("Harry Potter and the Chamber of Secrets", "J.K. Rowling", 1998, "Bloomsbury");
            InsertBooksData("Harry Potter and the Prisoner of Azkaban", "J.K. Rowling", 1999, "Bloomsbury");

            logger.info("Добавили книги в таблицу books.");

            // Функции для добавления данных в таблицу authors
            InsertAuthorsData("Jane Austen", "England");
            InsertAuthorsData("Gabriel Garcia Marquez", "Colombia");
            InsertAuthorsData("Lev Tolstoy", "Russia");
            InsertAuthorsData("Haruki Murakami", "Japan");
            InsertAuthorsData("J.K. Rowling", "United Kingdom");

            logger.info("Добавили авторов в таблицу authors.");

            // Вывод всех книг вышедшие в 2022 - 2023 году
            System.out.println("\nКниги вышедшие в 2022-2023 году:\n");
            selectBooksByYear(2023);
            selectBooksByYear(2022);

            logger.info("Вывели книги вышедшие в 2022-2023 году.");

            // Вывод информации об авторах
            System.out.println("\nИнформация об авторах:\n");
            printAuthorsInfo();

            logger.info("Вывели информацию об авторах.");

            // Вывод инофрмации об авторах которые написали больше 2 книг
            System.out.println("\nИнформация об авторах которые написали больше 2 книг:\n");
            printAuthorInfoBook(2);

            logger.info("Вывели информацию об авторах которые написали больше 2 книг.");


            //Удаляем книги вышедшие после 2015 года
            System.out.println("\nВыводим все наши книги:\n");
            printAllBooks();
            System.out.println("\nВыводим все наши книги после удаления:\n");
            deleteBooksByYear(2015);
            printAllBooks();

            logger.info("Удалили книги вышедшие после 2015 года.");


        } catch (Exception e) {
            System.out.println(e.getMessage());
            logger.info("Появилось исключение " + e.getMessage() + ".");

        }
    }

    private static void deleteBooksByYear(int year) {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(DELETE_BOOKS_BY_YEAR)) {
            statement.setInt(1, year);
            statement.executeUpdate();
        } catch (Exception e) {
            System.out.println(e.toString());

        }
    }

    private static void printAllBooks() {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(SELECT_ALL_BOOKS)) {
            ResultSet resultSet = statement.executeQuery();
            while (resultSet.next()) {
                int id = resultSet.getInt("id");
                String title = resultSet.getString("title");
                String author = resultSet.getString("author");
                int bookYear = resultSet.getInt("year");
                String producer = resultSet.getString("producer");
                System.out.printf("%d %s %s %d %s\n", id, title, author, bookYear, producer);
            }
        } catch (Exception e) {
            System.out.println(e.toString());

        }
    }

    private static void printAuthorsInfo() {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(SELECT_AUTHORS_QUERY)) {
            ResultSet resultSet = statement.executeQuery();
            while (resultSet.next()) {
                int id = resultSet.getInt("id");
                String name = resultSet.getString("name");
                String country = resultSet.getString("country");
                System.out.printf("%d %s %s\n", id, name, country);
            }
        } catch (Exception e) {
            System.out.println(e.toString());

        }
    }

    public static void InsertBooksData(String title, String author, int year, String producer) {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(INSERT_BOOKS_QUERY)) {
            statement.setString(1, title);
            statement.setString(2, author);
            statement.setInt(3, year);
            statement.setString(4, producer);
            statement.executeUpdate();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void InsertAuthorsData(String name, String country) {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(INSERT_AUTHORS_QUERY)) {
            statement.setString(1, name);
            statement.setString(2, country);
            statement.executeUpdate();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void DeleteData() {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(DELETE_BOOKS_QUERY);
             PreparedStatement statement2 = connection.prepareStatement(DELETE_AUTHORS_QUERY)) {
            statement.executeUpdate();
            statement2.executeUpdate();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void selectBooksByYear(int year) {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(SELECT_BOOKS_QUERY)) {
            statement.setInt(1, year);
            ResultSet resultSet = statement.executeQuery();
            while (resultSet.next()) {
                int id = resultSet.getInt("id");
                String title = resultSet.getString("title");
                String author = resultSet.getString("author");
                int bookYear = resultSet.getInt("year");
                String producer = resultSet.getString("producer");
                System.out.printf("%d %s %s %d %s\n", id, title, author, bookYear, producer);
            }
        } catch (Exception e) {
            System.out.println(e.toString());

        }
    }

    public static void printAuthorInfoBook(int n) {
        try (Connection connection = DriverManager.getConnection(URL, USER, PASSWORD);
             PreparedStatement statement = connection.prepareStatement(SELECT_AUTHORS_BOOK_QUERY)) {
            statement.setInt(1, n);
            ResultSet resultSet = statement.executeQuery();
            while (resultSet.next()) {
                String name = resultSet.getString("name");
                String count = resultSet.getString("book_count");
                System.out.printf("%s - %s\n", name, count);
            }
        } catch (Exception e) {
            System.out.println(e.toString());

        }
    }
}