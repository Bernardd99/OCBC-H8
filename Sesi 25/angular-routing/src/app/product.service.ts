import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

import { Product } from './models/product';
import { PRODUCTS } from './models/mock-product';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  products = of(PRODUCTS)

  constructor() { }

  getProducts(): Observable<Product[]> {
    return this.products
  }

  getProduct (id: number): Observable<Product>{
    return this.products.pipe(map(products => products.filter(product => product.id == id)[0])) 
  }
}
