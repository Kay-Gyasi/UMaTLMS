import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {DashboardComponent} from "./components/dashboard/dashboard.component";
import {ViewRoomsComponent} from "./components/rooms/view-rooms/view-rooms.component";
import {AddRoomComponent} from "./components/rooms/add-room/add-room.component";
import {EditRoomComponent} from "./components/rooms/edit-room/edit-room.component";
import {ViewClassesComponent} from "./components/classes/view-classes/view-classes.component";
import {ViewLecturesComponent} from "./components/lectures/view-lectures/view-lectures.component";
import {EditLectureComponent} from "./components/lectures/edit-lecture/edit-lecture.component";

const routes: Routes = [
  {path:"", component:DashboardComponent},
  {path:"*", component:DashboardComponent},
  {path:"rooms", component: ViewRoomsComponent},
  {path:"rooms/add", component:AddRoomComponent},
  {path:"rooms/edit/:id", component:EditRoomComponent},
  {path:"classes", component:ViewClassesComponent},
  {path:"lectures", component:ViewLecturesComponent},
  {path:"lectures/edit/:id", component:EditLectureComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
