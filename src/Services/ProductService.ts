import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Product } from "src/Data/Product";
@Injectable()
export class productService{
    baseUrl:string="http://localhost/Inventory/api/Product";
    constructor(private httpclient:HttpClient){}

    insert(product:Product){
        debugger
         this.httpclient.post("http://localhost/Inventory/api/Product",product).subscribe()
   }

   getAll():Observable<any>{
       return this.httpclient.get(this.baseUrl+"/GetAll");
   }

   delete(id:number):Observable<any>{
       return this.httpclient.get(this.baseUrl+"/delete/"+id);
   }
   getById(id:number):Observable<any>{
       debugger
      return this.httpclient.get(this.baseUrl+"/GetById/"+id);
   }

   getByName(name:string):Observable<any>{
       return this.httpclient.get(this.baseUrl+"/GetByName/"+name);
   }

   update(product:Product):Observable<any>{
     return  this.httpclient.post(this.baseUrl+"/update",product);

   }



}