package lab3Java.JacksonParser;

        import com.fasterxml.jackson.annotation.JsonAutoDetect;
        import com.fasterxml.jackson.annotation.PropertyAccessor;
        import com.fasterxml.jackson.core.JsonProcessingException;
        import com.fasterxml.jackson.core.type.TypeReference;
        import com.fasterxml.jackson.databind.ObjectMapper;
        import com.fasterxml.jackson.databind.node.ObjectNode;
        import lab3Java.printedproduct.Book;
        import lab3Java.printedproduct.PrintedProduct;
        import java.io.*;
        import java.nio.file.Files;
        import java.nio.file.Paths;
        import java.util.ArrayList;
        import java.util.List;

public class JacksonParser {
    static int count = 0;
    public JacksonParser() {
        clearFile();
    }
    public void clearFile() {
        try {
            // Очистка файла "file.json"
            FileWriter fileWriter_start = new FileWriter("file.json");
            fileWriter_start.write("");
            fileWriter_start.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    public void Ser(Book book)
    {
        ObjectMapper objectMapper = new ObjectMapper();

        try {

            // Преобразование объекта Book в JSON-строку
            String json = objectMapper.writeValueAsString(book);
            System.out.println(json);

            // Запись JSON-строки в файл
            FileWriter fileWriter = new FileWriter("file.json",true);
            BufferedWriter bufferWriter = new BufferedWriter(fileWriter);
            bufferWriter.write(json);
            bufferWriter.write(",\n"); // добавляем запятую и перевод строки для разделения объектов
            bufferWriter.close();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    public void DeSer() throws FileNotFoundException {
        ObjectMapper objectMapper = new ObjectMapper();

        try {
            // Чтение JSON-строк из файла
            FileReader fileReader = new FileReader("file.json");
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            String line;

            // Считываем все строки из файла
            while ((line = bufferedReader.readLine()) != null) {
                // Вывод строки в формате JSON-объекта с переносом на новую строку
                System.out.println(line);
            }
            bufferedReader.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

//    public void DeSer() throws FileNotFoundException {
//        BufferedReader buf = new BufferedReader(new FileReader("file.json"));
//        try {
//            ObjectMapper mapper = new ObjectMapper();
//            mapper.setVisibility(PropertyAccessor.FIELD, JsonAutoDetect.Visibility.ANY);
//            String line = buf.readLine();
//            PrintedProduct prProducts[] = mapper.readValue(line, new TypeReference<PrintedProduct[]>() {});
//            for (PrintedProduct c: prProducts) {
//                c.Info();
//            }
//
//        } catch (IOException e) {
//            throw new RuntimeException(e);
//        }
//    }
}
