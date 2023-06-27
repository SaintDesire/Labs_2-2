package com.bookstore;

import java.util.ArrayList;
import java.util.Collections;

public class Seller {

    private ArrayList<Book> books;
    private ArrayList<Journal> journals;
    private ArrayList<Newspaper> newspapers;

    public Seller() {
        this.books = new ArrayList<>();
        this.journals = new ArrayList<>();
        this.newspapers = new ArrayList<>();
    }

    public void addBook(Book book) {
        books.add(book);
    }

    public void addJournal(Journal journal) {
        journals.add(journal);
    }

    public void addNewspaper(Newspaper newspaper) {
        newspapers.add(newspaper);
    }

    public ArrayList<Book> getBooks() {
        return books;
    }

    public ArrayList<Journal> getJournals() {
        return journals;
    }

    public ArrayList<Newspaper> getNewspapers() {
        return newspapers;
    }

    public void sortBooksByYear() {
        Collections.sort(books, (b1, b2) -> b1.getYear() - b2.getYear());
    }

    public PrintedEdition findPrintedEditionByTitle(String title) {
        for (Book book : books) {
            if (book.getTitle().equals(title)) {
                return book;
            }
        }
        for (Journal journal : journals) {
            if (journal.getTitle().equals(title)) {
                return journal;
            }
        }
        for (Newspaper newspaper : newspapers) {
            if (newspaper.getTitle().equals(title)) {
                return newspaper;
            }
        }
        return null;
    }

    public boolean sellPrintedEdition(PrintedEdition printedEdition) {
        if (printedEdition instanceof Book) {
            return books.remove(printedEdition);
        } else if (printedEdition instanceof Journal) {
            return journals.remove(printedEdition);
        } else if (printedEdition instanceof Newspaper) {
            return newspapers.remove(printedEdition);
        }
        return false;
    }

    public class SalesReport {
        private int totalSales;

        public SalesReport(int totalSales) {
            this.totalSales = totalSales;
        }

        public int getTotalSales() {
            return totalSales;
        }

        public void setTotalSales(int totalSales) {
            this.totalSales = totalSales;
        }
    }
}
