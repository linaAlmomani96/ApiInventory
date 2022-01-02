import { HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Brand } from 'src/Data/Brand';
@Injectable()
export class brandService{
    baseUrl:string = "http://localhost/Inventory/api/Brand";
    constructor(private httpclient:HttpClient){}

    insert(brand:Brand):Observable<any>{
         return this.httpclient.post(this.baseUrl,brand)
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

    update(brand:Brand):Observable<any>{
      return  this.httpclient.post(this.baseUrl+"/update",brand);

    }
}