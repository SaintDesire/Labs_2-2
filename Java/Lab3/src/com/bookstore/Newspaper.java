package com.bookstore;

public class Newspaper extends PrintedEdition {
    private String editor;

    public Newspaper(String title, String publisher, int year, double price, int quantity, String editor) {
        super(title, publisher, year, price, quantity);
        this.editor = editor;
    }

    public String getEditor() {
        return editor;
    }

    public void setEditor(String editor) {
        this.editor = editor;
    }

    @Override
    public String toString() {
        return "Newspaper{" +
                "title='" + getTitle() + '\'' +
                ", publisher='" + getPublisher() + '\'' +
                ", year=" + getYear() +
                ", price=" + getPrice() +
                ", quantity=" + getQuantity() +
                ", editor='" + editor + '\'' +
                '}';
    }
}
