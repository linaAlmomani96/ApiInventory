import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Attribute } from 'src/Data/Attribute';
import { Observable } from "rxjs";
@Injectable()
export class attributeService{
    baseUrl:string = "http://localhost/Inventory/api/Attribute/";
    constructor(private httpClient:HttpClient){}
    insert(attribute:Attribute):Observable<any>{
          return this.httpClient.post(this.baseUrl,attribute);
    }
    getAll():Observable<any>{
        return this.httpClient.get(this.baseUrl+"GetAll");
    }
 
    delete(id:number):Observable<any>{
        return this.httpClient.get(this.baseUrl+"delete/"+id);
    }
    getById(id:number):Observable<any>{
        debugger
       return this.httpClient.get(this.baseUrl+"GetById/"+id);
    }
 
    getByName(name:string):Observable<any>{
        return this.httpClient.get(this.baseUrl+"GetByName/"+name);
    }
 
    update(attribute:Attribute):Observable<any>{
      return  this.httpClient.post(this.baseUrl+"update",attribute);
 
    }
    CountAtribute():Observable<any>{
        return this.httpClient.get(this.baseUrl+"CountAtribute");
    }

}