import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { AppComponent } from './app.component';
import { HomeComponent,  } from './components/home/home.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    component: HomeComponent,
    data: { title: 'Home - Easy Event' }
  },
  { path: '',
    redirectTo: '/',
    pathMatch: 'full'
  },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PageNotFoundComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
