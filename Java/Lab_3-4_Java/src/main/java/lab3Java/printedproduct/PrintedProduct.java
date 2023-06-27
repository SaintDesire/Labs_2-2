package lab3Java.printedproduct;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.apache.log4j.Logger;

import java.util.Comparator;
import java.util.Date;

public abstract class PrintedProduct implements Comparator<PrintedProduct> {
        private static final Logger LOG =
                Logger.getLogger(PrintedProduct.class);
    @JsonProperty("Title")
    private String Title;

    public PrintedProduct() {

    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    @JsonProperty("Price")
    private int Price;
    public int getPrice() {
        return Price;
    }

    public void setPrice(int price) {
        Price = price;
    }

    @JsonProperty("YearOfPublication")
    private int YearOfPublication;
    public int getYearOfPublication() {
        return YearOfPublication;
    }

    public void setYearOfPublication(int yearOfPublication) {
        YearOfPublication = yearOfPublication;
    }

    public PrintedProduct(String Title, int Price, int YearOfPublication){
        this.Title = Title;
        this.Price = Price;
        this.YearOfPublication = YearOfPublication;
    }

    public abstract void Info();
}
