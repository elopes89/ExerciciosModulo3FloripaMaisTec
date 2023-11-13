import { CapacitorConfig } from '@capacitor/cli';

const config: CapacitorConfig = {
  appId: 'com.example.app',
  appName: 'sucesso-total',
  webDir: 'dist',
  bundledWebRuntime: false,
    server: {
      url:'https://192.168.0.13:4200',
      cleartext: true
    // androidScheme: 'https'
  }
};

export default config;

 // {
    //   "id": 3,
    //   "modelo": "g-shock",
    //   "marca": "casio",
    //   "cor": "preto",
    //   "urlImagem": "/assets/Images/IMG-20230802-WA0002.jpg",
    //   "preco": 120
    // },

    // {
    //   "id": 4,
    //   "modelo": "g-shock",
    //   "marca": "casio",
    //   "cor": "azul detalhes laranja",
    //   "urlImagem": "/assets/Images/IMG-20230802-WA0004.jpg",
    //   "preco": 150
    // },
    // {
    //   "id": 5,
    //   "modelo": "g-shock",
    //   "marca": "casio",
    //   "cor": "azul",
    //   "urlImagem": "/assets/Images/IMG-20230802-WA0005.jpg",
    //   "preco": 150
    // },
    // {
    //   "id": 6,
    //   "modelo": "g-shock",
    //   "marca": "casio",
    //   "cor": "amarelo",
    //   "urlImagem": "/assets/Images/IMG-20230802-WA0007.jpg",
    //   "preco": 150
    // },
    // {
    //   "id": 7,
    //   "modelo": "g-shock",
    //   "marca": "casio",
    //   "cor": "cinza",
    //   "urlImagem": "/assets/Images/IMG-20230802-WA0008.jpg",
    //   "preco": 150
    // }
