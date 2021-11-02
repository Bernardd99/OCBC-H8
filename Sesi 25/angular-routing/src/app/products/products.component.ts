import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductService } from '../product.service';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];


  // products = any[
  //   {
  //     id: 1,
  //     code: "B001",
  //     name: "Acoustic Guitar",
  //     price: 99
  //   },
  //   {
  //     id: 2,
  //     code: "B002",
  //     name: "Classic Guitar",
  //     price: 79
  //   },
  //   {
  //     id: 3,
  //     code: "B003",
  //     name: "Electric Guitar",
  //     price: 129
  //   },
  // ]

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts() {
    this.productService.getProducts().subscribe(products => this.products = products);
  }

}
