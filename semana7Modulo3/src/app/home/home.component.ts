import { Component } from '@angular/core';
import { IUsuario } from 'IUsuario';
import { IntegracaoService } from '../service/integracao.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {


  registerForm!: FormGroup;
  usuariosArr: Array<IUsuario> = []
  constructor(private integracao: IntegracaoService, private builder: FormBuilder) {
    this.buscar()
  }


  ngOnInit(): void {
    this.registerForm = this.builder.group({
      codigo: [''],
      nome: [''],
      dataDeNascimento: [],
      email: ['']
    })
  }
  enviar() {
    this.integracao.add(this.registerForm.value).subscribe(user => {
      this.usuariosArr.push(user);
      console.log(this.registerForm.value)
      this.buscar();
    })

  }
  usuarios: any

  buscar() {
    this.integracao.getAll().subscribe(user => {
      this.usuarios = user;
      console.log(this.usuarios);
    })
  }

  deletar(id: number) {
    this.integracao.remove(id).subscribe(_ => {
      this.buscar();
    })
    // alert("removido")
  }
}
