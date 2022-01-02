import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Subscriber } from 'rxjs';
import { AttributeValue } from 'src/Data/AttributeValue';
import { AttributeValueService } from 'src/Services/AttributeValueService';

@Component({
  selector: 'app-attribute-value',
  templateUrl: './attribute-value.component.html',
  styleUrls: ['./attribute-value.component.css']
})
export class AttributeValueComponent implements OnInit {
  popAdd:boolean=false;
  @ViewChild('F') valueAttrForm:NgForm;
  showMsg:boolean = false;
  msg:string;
  statusClass:string = "active";
  tableMsg:boolean = false;
  savePopup:string = "insert"

  attributesValue:any =0
  attributeValueName:string
  attributeValueId:number
  constructor(private attService:AttributeValueService,private rout:ActivatedRoute) { }

  ngOnInit(): void {
    debugger;
  this.attributeValueId = this.rout.snapshot.queryParams["Id"];
  this.attributeValueName = this.rout.snapshot.queryParams["Name"];
  this.attService.getAttrValues(this.attributeValueId).subscribe(data=>{
   this.attributesValue = data
  })
  }
  OnSave(){
    debugger;
    this.valueAttrForm.form.patchValue({
    "attribute_Id":this.attributeValueId
    });
    let value = new AttributeValue()
    value.name =  this.valueAttrForm.value["txtName"];
    // value.attribute_Id = this.attributeValueId
    value.attribute_Id=parseInt(this.valueAttrForm.value["attribute_Id"]);
    this.attService.insert(value).subscribe(a=>{
      this.showMsg =true
      this.msg = "Created"
      
      this.attService.getAttrValues(this.attributeValueId).subscribe(data=>{
        this.attributesValue = data
       })
    

    }) 
     this.popAdd = false
  }
 

  OnDelete(id:number){
    this.attService.delete(id).subscribe(d =>{
           this.attService.getAttrValues(this.attributeValueId).subscribe(data=>{
        this.attributesValue = data
       })
       this.showMsg = true;
       this.msg = "Removed";
    })
  
  }

  GetById(id:number){
    let value = new AttributeValue()
   this.attService.getById(id).subscribe(data =>{
    value =data
    this.popAdd = true
    this.savePopup = "update"
    this.valueAttrForm.form.patchValue({
      "txtId":value.id,
      "txtName":value.name,
      "attribute_Id":value.attribute_Id
    })
   })


  }



  getByName(name:any){
    debugger
  let Name = name.target.value;
    this.attService.getByName(Name).subscribe(data =>{
      this.attributesValue = data;
    })
  }

  OnUpdate(){
    let value = new AttributeValue()
    value.id = parseInt(this.valueAttrForm.value["txtId"])
    value.name = this.valueAttrForm.value["txtName"]
    value.attribute_Id = parseInt(this.valueAttrForm.value["attribute_Id"])
     this.attService.update(value).subscribe(a =>{
      this.attService.getAttrValues(this.attributeValueId).subscribe(data=>{
        this.attributesValue = data
       })
       this.showMsg = true;
       this.msg = "Updated";
     })

     this.popAdd = false;

   
  }



}
