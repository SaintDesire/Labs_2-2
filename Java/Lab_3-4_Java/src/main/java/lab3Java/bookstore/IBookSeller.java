package lab3Java.bookstore;

import lab3Java.printedproduct.PrintedProduct;

interface IBookSeller{
    void SortProductsByYear();
    PrintedProduct SearchProductByTitle(String Title);
    void AddProduct(PrintedProduct pr);
    void SellProduct(PrintedProduct pr);
}
