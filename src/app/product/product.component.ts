import { Component, OnInit, ViewChild } from '@angular/core';
import { AttributeValueService } from 'src/Services/AttributeValueService';
import { brandService } from 'src/Services/BrandService';
import { categoryService } from 'src/Services/CategoryService';
import { productService } from 'src/Services/ProductService';
import { storeService } from 'src/Services/StoreService';
import {Location} from '@angular/common';
import { Product } from 'src/Data/Product';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
 colors:any
 sizes:any
 barnds:any
 categories:any
 stores:any
 fileToUpload:File|null
 @ViewChild("F") productForm:NgForm

 formData:any
 file:File
  constructor(private productServ:productService,private attributeValueServ:AttributeValueService,
    private brandServ:brandService,private categoryServ:categoryService,private storServ:storeService,private _location: Location) { }

  ngOnInit(): void {
  this.attributeValueServ.getAllColors().subscribe(data =>{
    this.colors = data
  })
  this.attributeValueServ.getAllSize().subscribe(data =>{
    this.sizes = data
  })
  this.brandServ.getAll().subscribe(data =>{
 this.barnds = data
  })
  this.categoryServ.getAll().subscribe(data =>{
    this.categories = data
  })
  this.storServ.getAll().subscribe(data=>{
    this.stores = data
  })
  }

  onFileSelected(event:any) {
    debugger;

     this.file = event.target.files[0];

    



      if (this.file) {

 
           this.formData = new FormData();

          this.formData.append("thumbnail", this.file);

          // const upload$ = this.http.post("/api/thumbnail-upload", formData);

          // upload$.subscribe();
      }
}


  onSave(){
    debugger;
    let product = new Product()
    product.name = this.productForm.value["txtName"]
    // if(this.productForm.value["uploadImg"].length >0)
    product.filePath =this.file
    product.sku = this.productForm.value["txtSuk"]
    product.price =parseFloat(this.productForm.value["txtPrice"])
    product.qty =parseInt(this.productForm.value["txtQty"])
    product.description = this.productForm.value["txtDescription"]
    product.colorId =parseInt(this.productForm.value["ddlColor"])
    product.sizeId =parseInt(this.productForm.value["ddlSize"])
    product.brandId =parseInt(this.productForm.value["ddlBrand"])
    product.colorId =parseInt(this.productForm.value["ddlCategory"])
    product.storeId =parseInt(this.productForm.value["ddlStore"])
    product.status = this.productForm.value["ddlAvailablity"]

    this.productServ.insert(product);

  }
  goBack(){
    // Actually you can take advantage of the built-in Location service, which owns a "Back" API.
   
    // this._location.forward()
    this._location.back()
  }

}
