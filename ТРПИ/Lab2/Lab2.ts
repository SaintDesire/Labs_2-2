interface IProduct
{
    get Type(): string;
    get ID(): number;
    get Size() : number;
    get Color() : string;
    get Price() : number;
    set Price(v : number);
    toString(): string;
}

class Product implements IProduct
{
    id: number;
    size : number;
    color : string;
    price : number;
    discount : number;
    endPrice : number;
    type: string;

    public get Type():string
    {
        return this.type;
    }

    public get ID(): number
    {
        return this.id;
    }
    public get Size() : number
    {
        return this.size;
    }

    public get Color() : string
    {
        return this.color;
    }

    public get Price() : number
    {
        return this.endPrice;
    }

    public set Price(v : number)
    {
        this.price = v;
        this.endPrice = (100 - this.discount) * this.price / 100;
    }

    constructor(ID: number,type: string, price: number, Size: number, color: string, discount: number = 0) {
        this.discount = 0;
        this.id = ID;
        this.size = Size;
        this.color = color;
        this.discount = discount;
        this.price = price;
        this.endPrice = (100 - discount) * price / 100;
        this.type = type;
    }

    public toString() : string
    {
        return(`id: ${this.id}\n name: ${this.type} \n color: ${this.color} \n size: ${this.size}\n price: ${this.endPrice}` );
    }
}
let products = [
    new Product(1,"Sneakers", 150, 42, "black"),
    new Product(2,"Boots", 200, 46, "black", 20),
    new Product(3,"Sandals", 50, 42, "white", 35),
    new Product(4,"Boots", 80, 44, "dark-blue", 25),
    new Product(5,"Sneakers", 250, 47, "white", 7),
    new Product(6,"Sandals", 70, 45, "pink", 15)
];

//Задание_2
interface IProductIterator
{
    index: number;
    next() : any;
}

class ProductIterator implements IProductIterator
{
    index: number
    constructor(public products: Product[])
    {
        this.index = -1;
        this.products = products;
    }

    public next() : any
    {
        if (this.index < products.length-1)
        {
            return { done: false, value: products[++this.index] };
        }
        else {
            return { done: true, value: null };
        }
    }
}
let iterator: ProductIterator = new ProductIterator(products);
let prod: any = iterator.next();

let iterator2: ProductIterator = new ProductIterator(products);
let prod2: any = iterator2.next();

while(prod.done != true)
{
    Object.defineProperty(prod.value, 'id', {
        writable: false,
        configurable: false
    })
    Object.defineProperty(prod.value, 'color', {
        writable: false
    })
    Object.defineProperty(prod.value, 'size', {
        writable: false
    })
    console.log( prod.value );
    prod=iterator.next();
}

while(prod2.done != true)
{
    delete prod2.value.id;
    console.log( prod2.value.id );
    prod2 = iterator2.next();
}

//Задание_3

function sortByPrice(minPrice: number, maxPrice: number) : void
{
    console.log("\nSort by price:");
    products.forEach(Element => {
        if(Element.price > minPrice && Element.price < maxPrice)
        {
            console.log(Element.id);
        }
    });
}

function sortByColor(color: string) : void
{
    console.log('\nFilter by color: ');
    products.forEach(element => {
        if (element.color == color) {
            console.log(element.id);
        }
    });
}

function sortBySize(size: number) : void
{
    console.log('\nFilter by size: ');
    products.forEach(element => {
        if(element.size == size)
        {
            console.log(element.id);
        }
    });
}

sortBySize(46);
sortByColor("white");
sortByPrice(60, 180);