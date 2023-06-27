package com.bookstore;

public class Journal extends PrintedEdition {
    private int issueNumber;

    public Journal(String title, String author, int year, double price, int quantity, int issueNumber) {
        super(title, author, year, price, quantity);
        this.issueNumber = issueNumber;
    }

    public int getIssueNumber() {
        return issueNumber;
    }

    public void setIssueNumber(int issueNumber) {
        this.issueNumber = issueNumber;
    }

    @Override
    public String toString() {
        return "Journal{" +
                "publisher='" + getPublisher() + '\'' +
                ", issueNumber=" + issueNumber +
                ", " + super.toString() +
                '}';
    }

}