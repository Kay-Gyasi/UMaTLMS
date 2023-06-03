import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {DashboardComponent} from "./components/dashboard/dashboard.component";
import {ViewRoomsComponent} from "./components/rooms/view-rooms/view-rooms.component";
import {AddRoomComponent} from "./components/rooms/add-room/add-room.component";
import {EditRoomComponent} from "./components/rooms/edit-room/edit-room.component";

const routes: Routes = [
  {path:"", component:DashboardComponent},
  {path:"*", component:DashboardComponent},
  {path:"rooms", component: ViewRoomsComponent},
  {path:"rooms/add", component:AddRoomComponent},
  {path:"rooms/edit", component:EditRoomComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
