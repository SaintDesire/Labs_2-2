import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;
import org.testng.Assert;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.DocumentBuilder;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import java.io.File;

public class TestNGDataProvider {

    @DataProvider(name = "testData")
    public Object[][] readTestData() {
        try {
            File inputFile = new File("src/testng.xml");
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document doc = dBuilder.parse(inputFile);
            doc.getDocumentElement().normalize();

            NodeList nodeList = doc.getElementsByTagName("test");
            Object[][] testData = new Object[nodeList.getLength()][2];

            for (int i=0; i < nodeList.getLength(); i++) {
                Element element = (Element) nodeList.item(i);
                testData[i][0] = element.getElementsByTagName("input").item(0).getTextContent();
                testData[i][1] = element.getElementsByTagName("output").item(0).getTextContent();
            }
            return testData;

        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    @Test(dataProvider = "testData")
    public void test(String input, String expectedOutput) {
        int actualOutput = myFunction(input);
        Assert.assertEquals(actualOutput, Integer.parseInt(expectedOutput));
    }

    public int myFunction(String input) {
        // Implement your function here
        return input.equals("a") ? 1 : 2;
    }
}