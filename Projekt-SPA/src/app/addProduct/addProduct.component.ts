import { Component, OnInit } from '@angular/core';
import { ProductService } from '../_services/product.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addProduct.component.html',
  styleUrls: ['./addProduct.component.css']
})
export class AddProductComponent implements OnInit {
  model: any = {};

  constructor(private authService: ProductService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  addproduct() {
    this.authService.addproduct(this.model).subscribe(() => {
      this.alertify.success('Dodano produkt');
    }, error => {
      this.alertify.error(error);
    });
  }

}
