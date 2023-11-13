import { Component, OnInit } from '@angular/core';
import { LojaService } from './service/loja.service';
import { IRelogio } from 'Interface/IRelogio';
import { Camera, CameraResultType, CameraSource } from '@capacitor/camera';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'sucessoTotal';
  relogios: Array<IRelogio> = [];
  constructor(private ls: LojaService) {
  }
  kb() {
    this.ls.getAll().subscribe((not) => {
      this.relogios = not;
    });
  }

  ngOnInit(): void {
    this.ls.getAll().subscribe((not) => {
      this.relogios = not;
    });
  }
  image = '';
  async captureImage() {
    const image = await Camera.getPhoto({
      quality: 90,
      allowEditing: true,
      source: CameraSource.Prompt,
      resultType: CameraResultType.Base64
    })
    if (image) {
      this.image = `data:image/jpeg;base64,${image.base64String}`
    }
  }
}
