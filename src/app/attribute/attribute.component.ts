import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Attribute } from 'src/Data/Attribute';
import { AttributeDto } from 'src/Data/AttributeDto';
import { Category } from 'src/Data/Category';
import { attributeService } from 'src/Services/AttributeService';


@Component({
  selector: 'app-attribute',
  templateUrl: './attribute.component.html',
  styleUrls: ['./attribute.component.css']
})
export class AttributeComponent implements OnInit {

  popAdd:boolean=false;
  @ViewChild('F') categoryForm:NgForm;
  showMsg:boolean = false;
  msg:string;
  attributes:any =0;
  statusClass:string = "active";
  tableMsg:boolean = false;
  savePopup:string = "insert"
  atributeDto:AttributeDto[];
  attrId:number
  attributeCount:number

  constructor(private attService:attributeService,private rout:Router) {}
  ngOnInit(): void {
    debugger;
   this.attService.CountAtribute().subscribe(data=>{
     this.atributeDto = data;
   })
 
  }
  OnSave(){
    debugger;
   let attribute = new Attribute();
   attribute.name = this.categoryForm.value['txtName'];
   attribute.status = this.categoryForm.value['ddlStatus'];

     this.attService.insert(attribute).subscribe(a=>{
      this.showMsg = true;
      this.msg = "Created";

    this.attService.CountAtribute().subscribe(data=>{
      this.atributeDto = data;});

     });
     
       this.popAdd = false
     
  
  }
 

  OnDelete(id:number){
    debugger;

   this.attService.delete(id).subscribe( d=>{
    // this.attService.getAll().subscribe((data) =>{
    //   this.attributes = data;
    //  })

    this.attService.CountAtribute().subscribe(data=>{
      this.atributeDto = data;});
      this.showMsg = true;
      this.msg = "Removed";
   });

 
  }

  GetById(id:number){
    debugger;
    let attribute = new Attribute();
  this.attService.getById(id).subscribe(data =>{
    debugger;
    attribute = data
   
      this.popAdd=true;
      this.savePopup = "update"
      this.categoryForm.form.patchValue({
        "txtId":attribute.id,
        "txtName":attribute.name,
        "ddlStatus":attribute.status
      }); 
  })

  }



  getByName(name:any){
    debugger
  let Name = name.target.value;
    this.attService.getByName(Name).subscribe(data =>{
      this.atributeDto = data;
    })
  }

  OnUpdate(){
    let attribute = new Attribute();
    attribute.id = parseInt(this.categoryForm.value["txtId"]);
    attribute.name = this.categoryForm.value["txtName"];
    attribute.status = this.categoryForm.value["ddlStatus"];
  this.attService.update(attribute).subscribe(d =>{

  this.attService.CountAtribute().subscribe(data=>{
    this.atributeDto = data;});
   this.showMsg = true;
   this.msg = "Updated";
});
this.popAdd = false
  }

  GetValues(id:number,name:string){
    debugger;
    this.rout.navigate(['/attribute-val'],{queryParams:{Id:id,Name:name}});

   
  }



}
