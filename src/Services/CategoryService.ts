import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Category } from "src/Data/Category";
@Injectable()
export class categoryService{
    baseUrl:string="http://localhost/Inventory/api/Category/";
    constructor(private httpclient:HttpClient){}

    insert(category:Category):Observable<any>{
        return this.httpclient.post(this.baseUrl,category)
   }

   getAll():Observable<any>{
       return this.httpclient.get(this.baseUrl+"GetAll");
   }

   delete(id:number):Observable<any>{
       return this.httpclient.get(this.baseUrl+"delete/"+id);
   }
   getById(id:number):Observable<any>{
       debugger
      return this.httpclient.get(this.baseUrl+"GetById/"+id);
   }

   getByName(name:string):Observable<any>{
       return this.httpclient.get(this.baseUrl+"GetByName/"+name);
   }

   update(category:Category):Observable<any>{
     return  this.httpclient.post(this.baseUrl+"update",category);

   }



}