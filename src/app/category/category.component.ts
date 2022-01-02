import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Category } from 'src/Data/Category';
import { categoryService } from 'src/Services/CategoryService';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
  popAdd:boolean=false;
  @ViewChild('F') categoryForm:NgForm;
  showMsg:boolean = false;
  msg:string;
  categories:any =0;
  statusClass:string = "active";
  tableMsg:boolean = false;
  savePopup:string = "insert"
  

  constructor(private categoryService:categoryService) {}
  ngOnInit(): void {
    debugger;
    this.categoryService.getAll().subscribe(data =>{
     this.categories = data;
    })

 
  }
  OnSave(){
    debugger;
   let category = new Category();
     category.name = this.categoryForm.value['txtName'];
     category.status = this.categoryForm.value['ddlStatus'];

     this.categoryService.insert(category).subscribe(a=>{
      this.showMsg = true;
      this.msg = "Created";
       this.categoryService.getAll().subscribe(data =>{
      this.categories = data;
     })
     });
     
       this.popAdd = false
     
  
  }
 

  OnDelete(id:number){
    debugger;

   this.categoryService.delete(id).subscribe( d=>{
    this.categoryService.getAll().subscribe(data =>{
      this.categories = data;
     })
   });
    this.showMsg = true;
   this.msg = "Removed";
 
  }

  GetById(id:number){
    debugger;
    let category:Category =new Category();
  this.categoryService.getById(id).subscribe(data =>{
    debugger;
    category = data
    if(category !=null)
    {
      this.popAdd=true;
      this.savePopup = "update"
      this.categoryForm.form.patchValue({
        "txtId":category.id,
        "txtName":category.name,
        "ddlStatus":category.status
      });

    }
    

  })


  }



  getByName(name:any){
  let brandName = name.target.value;
    this.categoryService.getByName(brandName).subscribe(data =>{
      this.categories = data;
    })
  }

  OnUpdate(){
let category:Category = new Category();
category.id = parseInt(this.categoryForm.value["txtId"]);
category.name = this.categoryForm.value["txtName"];
category.status = this.categoryForm.value["ddlStatus"];
this.categoryService.update(category).subscribe(d =>{
  this.categoryService.getAll().subscribe(data =>{
    this.categories = data;
   })
   this.showMsg = true;
   this.msg = "Updated";
});
this.popAdd = false
  }

}
