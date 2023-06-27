package com.bookstore;

public abstract class PrintedEdition implements IPrintedEdition{
    private String title;
    private String publisher;
    private int year;
    private double price;
    private int quantity;

    public PrintedEdition(String title, String publisher, int year, double price, int quantity) {
        this.title = title;
        this.publisher = publisher;
        this.year = year;
        this.price = price;
        this.quantity = quantity;
    }

    public String getTitle() {
        return title;
    }

    public String getPublisher() {
        return publisher;
    }

    public void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    public int getYear() {
        return year;
    }

    public double getPrice() {
        return price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public void decreaseQuantity(int quantity) {
        this.quantity -= quantity;
    }

    @Override
    public String toString() {
        return "PrintedEdition{" +
                "title='" + title + '\'' +
                ", publisher='" + publisher + '\'' +
                ", year=" + year +
                ", price=" + price +
                ", quantity=" + quantity +
                '}';
    }
}
