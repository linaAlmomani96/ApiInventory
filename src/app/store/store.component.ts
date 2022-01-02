import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Store } from 'src/Data/Store';
import { storeService } from 'src/Services/StoreService';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent implements OnInit {

  popAdd:boolean=false;
  @ViewChild('F') storeForm:NgForm;
  showMsg:boolean = false;
  msg:string;
  stores:any =0;
  statusClass:string = "active";
  tableMsg:boolean = false;
  savePopup:string = "insert"
  

  constructor(private StoreService:storeService) {}
  ngOnInit(): void {
    debugger;
    this.StoreService.getAll().subscribe(data =>{
     this.stores = data;
    })

 
  }
  OnSave(){
    debugger;
    let store= new Store();
     store.name = this.storeForm.value['txtName'];
     store.status = this.storeForm.value['ddlStatus'];

     this.StoreService.insert(store).subscribe(a=>{
      this.showMsg = true;
      this.msg = "Created";
       this.StoreService.getAll().subscribe(data =>{
      this.stores = data;
     })
     });
     
       this.popAdd = false
     
  
  }
 

  OnDelete(id:number){
    debugger;

   this.StoreService.delete(id).subscribe( d=>{
    this.StoreService.getAll().subscribe(data =>{
      this.stores = data;
     })
   });
    this.showMsg = true;
   this.msg = "Removed";
 
  }

  GetById(id:number){
    debugger;
    let store= new Store();
  this.StoreService.getById(id).subscribe(data =>{
    debugger;
    store = data
    if(store !=null)
    {
      this.popAdd=true;
      this.savePopup = "update"
      this.storeForm.form.patchValue({
        "txtId":store.id,
        "txtName":store.name,
        "ddlStatus":store.status
      });

    }
    

  })


  }



  getByName(name:any){
  let brandName = name.target.value;
    this.StoreService.getByName(brandName).subscribe(data =>{
      this.stores = data;
    })
  }

  OnUpdate(){
let store= new Store();
store.id = parseInt(this.storeForm.value["txtId"]);
store.name = this.storeForm.value["txtName"];
store.status = this.storeForm.value["ddlStatus"];
this.StoreService.update(store).subscribe(d =>{
  this.StoreService.getAll().subscribe(data =>{
    this.stores = data;
   })
   this.showMsg = true;
   this.msg = "Updated";
});
this.popAdd = false
  }

}
