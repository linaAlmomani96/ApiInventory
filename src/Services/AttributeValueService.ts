import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, retry } from "rxjs";
import { AttributeValue } from "src/Data/AttributeValue";
@Injectable()
export class AttributeValueService{
    baseUrl:string = "http://localhost/Inventory/api/AttributeValue";
    constructor(private httpClient:HttpClient){}
    insert(value:AttributeValue):Observable<any>{
        debugger;
     return this.httpClient.post(this.baseUrl,value);
    }
    update(attributeValue:AttributeValue):Observable<any>{
        return this.httpClient.post(this.baseUrl+"/update",attributeValue);
    }
    delete(id:number):Observable<any>{
        return this.httpClient.get(this.baseUrl+"/delete/"+id);
    }
    getById(id:number):Observable<any>{
        return this.httpClient.get(this.baseUrl+"/GetById/"+id);
    }
    getByName(name:string):Observable<any>{
        return this.httpClient.get(this.baseUrl+"/GetByName/"+name);
    }
    getAttrValues(id:number):Observable<any>{
        return this.httpClient.get(this.baseUrl+"/GetAttrValues/"+id);
    }
    getAllColors():Observable<any>{
        return this.httpClient.get(this.baseUrl+"/GetAllColors");
    }
    getAllSize():Observable<any>{
        return this.httpClient.get(this.baseUrl+"/GetAllSize");
    }

}