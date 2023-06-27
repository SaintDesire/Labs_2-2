var Product = /** @class */ (function () {
    function Product(ID, type, price, Size, color, discount) {
        if (discount === void 0) { discount = 0; }
        this.discount = 0;
        this.id = ID;
        this.size = Size;
        this.color = color;
        this.discount = discount;
        this.price = price;
        this.endPrice = (100 - discount) * price / 100;
        this.type = type;
    }
    Object.defineProperty(Product.prototype, "Type", {
        get: function () {
            return this.type;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "ID", {
        get: function () {
            return this.id;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "Size", {
        get: function () {
            return this.size;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "Color", {
        get: function () {
            return this.color;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Product.prototype, "Price", {
        get: function () {
            return this.endPrice;
        },
        set: function (v) {
            this.price = v;
            this.endPrice = (100 - this.discount) * this.price / 100;
        },
        enumerable: false,
        configurable: true
    });
    Product.prototype.toString = function () {
        return ("id: ".concat(this.id, "\n name: ").concat(this.type, " \n color: ").concat(this.color, " \n size: ").concat(this.size, "\n price: ").concat(this.endPrice));
    };
    return Product;
}());
var products = [
    new Product(1, "Sneakers", 150, 42, "black"),
    new Product(2, "Boots", 200, 46, "black", 20),
    new Product(3, "Sandals", 50, 42, "white", 35),
    new Product(4, "Boots", 80, 44, "dark-blue", 25),
    new Product(5, "Sneakers", 250, 47, "white", 7),
    new Product(6, "Sandals", 70, 45, "pink", 15)
];
var ProductIterator = /** @class */ (function () {
    function ProductIterator(products) {
        this.products = products;
        this.index = -1;
        this.products = products;
    }
    ProductIterator.prototype.next = function () {
        if (this.index < products.length - 1) {
            return { done: false, value: products[++this.index] };
        }
        else {
            return { done: true, value: null };
        }
    };
    return ProductIterator;
}());
var iterator = new ProductIterator(products);
var prod = iterator.next();
var iterator2 = new ProductIterator(products);
var prod2 = iterator2.next();
while (prod.done != true) {
    Object.defineProperty(prod.value, 'id', {
        writable: false,
        configurable: false
    });
    Object.defineProperty(prod.value, 'color', {
        writable: false
    });
    Object.defineProperty(prod.value, 'size', {
        writable: false
    });
    console.log(prod.value);
    prod = iterator.next();
}
while (prod2.done != true) {
    delete prod2.value.id;
    console.log(prod2.value.id);
    prod2 = iterator2.next();
}
//Задание_3
function sortByPrice(minPrice, maxPrice) {
    console.log("\nSort by price:");
    products.forEach(function (Element) {
        if (Element.price > minPrice && Element.price < maxPrice) {
            console.log(Element.id);
        }
    });
}
function sortByColor(color) {
    console.log('\nFilter by color: ');
    products.forEach(function (element) {
        if (element.color == color) {
            console.log(element.id);
        }
    });
}
function sortBySize(size) {
    console.log('\nFilter by size: ');
    products.forEach(function (element) {
        if (element.size == size) {
            console.log(element.id);
        }
    });
}
sortBySize(46);
sortByColor("white");
sortByPrice(60, 180);
