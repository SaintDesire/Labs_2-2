package com.bookstore;

public class Book extends PrintedEdition {
    private String author;

    public Book(String title, String author, String publisher, int year, double price, int quantity) {
        super(title, publisher, year, price, quantity);
        this.author = author;
    }

    public String getAuthor() {
        return author;
    }

    @Override
    public String toString() {
        return "Book{" +
                "title='" + getTitle() + '\'' +
                ", author='" + author + '\'' +
                ", publisher='" + getPublisher() + '\'' +
                ", year=" + getYear() +
                ", price=" + getPrice() +
                ", quantity=" + getQuantity() +
                '}';
    }
}
