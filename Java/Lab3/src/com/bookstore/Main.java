package com.bookstore;

import java.util.InputMismatchException;
import java.util.Scanner;
import java.util.logging.Logger;
import java.util.logging.Level;

public class Main {
    private static final Logger logger = Logger.getLogger(Main.class.getName());

    public static void main(String[] args) {
        try {
            // Создаем экземпляр класса Seller
            Seller seller = new Seller();

            // Добавляем несколько книг
            seller.addBook(new Book("The Lord of the Rings", "J.R.R. Tolkien", "HarperCollins", 1954, 29.99, 10));
            seller.addBook(new Book("The Hobbit", "J.R.R. Tolkien", "Houghton Mifflin Harcourt", 1937, 12.99, 5));
            seller.addBook(new Book("The Catcher in the Rye", "J.D. Salinger", "Little, Brown and Company", 1951, 9.99, 7));
            seller.addBook(new Book("To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", 1960, 11.99, 12));

            // Добавляем несколько журналов
            seller.addJournal(new Journal("National Geographic", "National Geographic Partners", 1888, 4.99, 20, 1));
            seller.addJournal(new Journal("The Economist", "The Economist Group", 1843, 9.99, 30, 128));
            seller.addJournal(new Journal("Time", "Time USA, LLC", 1923, 5.99, 25, 256));

            // Добавляем несколько газет
            seller.addNewspaper(new Newspaper("The New York Times", "The New York Times Company", 1851, 2.99, 30, "Dean Baquet"));
            seller.addNewspaper(new Newspaper("The Guardian", "Guardian Media Group", 1821, 3.99, 25, "Katharine Viner"));
            seller.addNewspaper(new Newspaper("The Washington Post", "Nash Holdings", 1877, 4.99, 20, "Marty Baron"));

            logger.log(Level.INFO, "All printed editions have been added to the seller");

            // Сортируем книги по году выпуска
            seller.sortBooksByYear();

            logger.log(Level.INFO, "Books have been sorted by year");

            // Выводим все книги на экран
            System.out.println("All books:");
            for (Book book : seller.getBooks()) {
                System.out.println(book);
            }

            // Находим книгу по названию
            PrintedEdition printedEdition = seller.findPrintedEditionByTitle("The Lord of the Rings");
            System.out.println("\nPrinted edition with title 'The Lord of the Rings':\n" + printedEdition);

            // Продаем книгу
            boolean isSold = seller.sellPrintedEdition(printedEdition);
            if (isSold) {
                System.out.println("\nPrinted edition with title 'The Lord of the Rings' was sold successfully.");
                logger.log(Level.INFO, "Printed edition with title 'The Lord of the Rings' was sold successfully.");
            } else {
                System.out.println("\nFailed to sell printed edition with title 'The Lord of the Rings'.");
                logger.log(Level.INFO, "Failed to sell printed edition with title 'The Lord of the Rings'.");
            }

            // Выводим все книги на экран после продажи
            System.out.println("\nAll books after selling 'The Lord of the Rings':");
            for (Book book : seller.getBooks()) {
                System.out.println(book);
            }

            logger.log(Level.INFO, "Remaining books: " + seller.getBooks());
            logger.log(Level.INFO, "Remaining journals: " + seller.getJournals());
            logger.log(Level.INFO, "Remaining newspapers: " + seller.getNewspapers());
        }  catch (InputMismatchException e) {
            System.out.println("Input error: " + e.getMessage());
            logger.log(Level.SEVERE, "An error occurred: " + e.getMessage(), e);
        } catch (Exception e) {
            System.out.println("An error occurred: " + e.getMessage());
            logger.log(Level.SEVERE, "An error occurred: " + e.getMessage(), e);
        }
    }
}