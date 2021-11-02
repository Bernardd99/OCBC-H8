import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from '../product.service';
import { Product } from '../models/product';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {
  // products: Product{} = {};
  productId: number;
  product : Product = {} as Product;
  productService : ProductService;

  constructor(private actRoute: ActivatedRoute, productService : ProductService) {
    this.productId = this.actRoute.snapshot.params.id;
    this.productService = productService
  }

  ngOnInit(): void {
    this.getProduct(this.productId);
  }

  getProduct(id: number){
    this.productService.getProduct(id).subscribe(p => this.product = p)
  }
}
