import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './home/home.component';
import { KolcsonzokComponent } from './kolcsonzok/kolcsonzok.component';
import { KolcsonzesekComponent } from './kolcsonzesek/kolcsonzesek.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    KolcsonzokComponent,
    KolcsonzesekComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
