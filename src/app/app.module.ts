import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BrandComponent } from './brand/brand.component';
import { CategoryComponent } from './category/category.component';
import { StoreComponent } from './store/store.component';
import { ProductComponent } from './product/product.component';
import { ProductManagementComponent } from './product-management/product-management.component';
import { CompanyComponent } from './company/company.component';
import { AttributeComponent } from './attribute/attribute.component';
import { AttributeValueComponent } from './attribute-value/attribute-value.component';
import { OrderComponent } from './order/order.component';
import { ManageOrderComponent } from './manage-order/manage-order.component';
import { RouterModule,Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { brandService } from 'src/Services/BrandService';
import { categoryService } from 'src/Services/CategoryService';
import { storeService } from 'src/Services/StoreService';
import { attributeService } from 'src/Services/AttributeService';
import { AttributeValueService } from 'src/Services/AttributeValueService';
import { productService } from 'src/Services/ProductService';



const AppRoutes:Routes=[{path:'',component:BrandComponent},
                        {path:'category',component:CategoryComponent},
                        {path:'company',component:CompanyComponent},
                        {path:'mng-order',component:ManageOrderComponent},
                        {path:'order',component:OrderComponent},
                        {path:'product',component:ProductComponent},
                        {path:'product-mng',component:ProductManagementComponent},
                        {path:'store',component:StoreComponent},
                        {path:'attribute',component:AttributeComponent},
                        {path:'attribute-val',component:AttributeValueComponent}
                      ]
@NgModule({
  declarations: [
    AppComponent,
    BrandComponent,
    CategoryComponent,
    StoreComponent,
    ProductComponent,
    ProductManagementComponent,
    CompanyComponent,
    AttributeComponent,
    AttributeValueComponent,
    OrderComponent,
    ManageOrderComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(AppRoutes),
    FormsModule,
    HttpClientModule
    
  ],
  providers: [
    brandService,
    categoryService,
    storeService,
    attributeService,
    AttributeValueService,
    productService],
  bootstrap: [AppComponent]
})
export class AppModule { }
