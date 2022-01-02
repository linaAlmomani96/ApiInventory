import { Component, ElementRef, OnInit, ViewChild  } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Brand } from 'src/Data/Brand';
import { brandService } from 'src/Services/BrandService';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.css']
})
export class BrandComponent implements OnInit {
  popAdd:boolean=false;
  @ViewChild('F') brandForm:NgForm;
  showMsg:boolean = false;
  msg:string;
  brands:any =0;
  statusClass:string = "active";
  tableMsg:boolean = false;
  savePopup:string = "insert"

  constructor(private brandService:brandService) {}
  ngOnInit(): void {
    debugger;
    this.brandService.getAll().subscribe(data =>{
     this.brands = data;
    })

 
  }
  OnSave(){
    debugger;
   let brand = new Brand();
     brand.name = this.brandForm.value['txtName'];
     brand.status = this.brandForm.value['ddlStatus'];

     this.brandService.insert(brand).subscribe(a=>{
      this.showMsg = true;
      this.msg = "Created";
       this.brandService.getAll().subscribe(data =>{
      this.brands = data;
     })
     });
     
       this.popAdd = false
     
  
  }
 

  OnDelete(id:number){
    debugger;

   this.brandService.delete(id).subscribe( d=>{
    this.brandService.getAll().subscribe(data =>{
      this.brands = data;
     })
   });
    this.showMsg = true;
   this.msg = "Removed";
 
  }

  GetById(id:number){
    debugger;
    let brand:Brand =new Brand();
  this.brandService.getById(id).subscribe(data =>{
    debugger;
    brand = data
    if(brand !=null)
    {
      this.popAdd=true;
      this.savePopup = "update"
      this.brandForm.form.patchValue({
        "txtId":brand.id,
        "txtName":brand.name,
        "ddlStatus":brand.status
      });

    }
    

  })


  }



  getByName(name:any){
  let brandName = name.target.value;
    this.brandService.getByName(brandName).subscribe(data =>{
      this.brands = data;
    })
  }

  OnUpdate(){
let brand:Brand = new Brand();
brand.id = parseInt(this.brandForm.value["txtId"]);
brand.name = this.brandForm.value["txtName"];
brand.status = this.brandForm.value["ddlStatus"];
this.brandService.update(brand).subscribe(d =>{
  this.brandService.getAll().subscribe(data =>{
    this.brands = data;
   })
   this.showMsg = true;
   this.msg = "Updated";
});
this.popAdd = false
  }
}