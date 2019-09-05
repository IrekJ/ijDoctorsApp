import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HttpClientModule } from '@angular/common/http';

import { DoctorDetailComponent } from './doctorDetail/doctorDetail.component';
import { AppRoutingModule } from './app-routing.module';
import { DoctorSummaryComponent } from './doctorSummary/doctorSummary.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DataService } from './services/data.service';
import { AboutComponent } from './about/about.component';

@NgModule({
   declarations: [
      AppComponent,
      HomeComponent,
      DoctorDetailComponent,
      DoctorSummaryComponent,
      NavbarComponent,
      AboutComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      AppRoutingModule
   ],
   providers: [
      DataService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
