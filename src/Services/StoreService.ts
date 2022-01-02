import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Store } from "src/Data/Store";
@Injectable()
export class storeService{
    baseUrl:string="http://localhost/Inventory/api/Store/";
    constructor(private httpclient:HttpClient){}

    insert(store:Store):Observable<any>{
        return this.httpclient.post(this.baseUrl,store)
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

   update(store:Store):Observable<any>{
     return  this.httpclient.post(this.baseUrl+"update",store);

   }



}