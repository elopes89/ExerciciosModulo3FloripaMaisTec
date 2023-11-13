import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { HomeComponent } from './home.component';
import { CommonModule } from '@angular/common';
import { HomeRoutingModule } from './home-routing.module';
import { SharedModule } from '../shared/shared.module';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [CommonModule, HomeRoutingModule, FormsModule, ReactiveFormsModule, SharedModule, HttpClientModule],
  declarations: [HomeComponent],
})
export class HomeModule {}
