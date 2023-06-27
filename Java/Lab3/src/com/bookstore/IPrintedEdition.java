package com.bookstore;

public interface IPrintedEdition {
    String getTitle();
    String getPublisher();
    void setPublisher(String publisher);
    int getYear();
    double getPrice();
    int getQuantity();
    void setPrice(double price);
    void setQuantity(int quantity);
    void decreaseQuantity(int quantity);
}
