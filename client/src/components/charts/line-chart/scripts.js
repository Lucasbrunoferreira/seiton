export default {
  data () {
    return {
      columns: [{
        'type': 'string',
        'label': 'Year'
      }, {
        'type': 'number',
        'label': 'Vendas'
      }, {
        'type': 'number',
        'label': 'Quantidade'
      }],
      rows: [
        ['Maio', 1000, 400],
        ['Abril', 1170, 460],
        ['Março', 660, 1120],
        ['Fevereiro', 1030, 540]
      ],
      options: {
        legend: {
          textStyle: {
            color: '#ffffff'
          }
        },
        titleTextStyle: {
          color: '#fff',
          fontSize: '15',
          bold: false
        },
        height: 330,
        width: 630,
        title: 'Vendas x Qtd - Ultimos 4 meses',
        colors: ['#6BD8D1', '#164d49'],
        backgroundColor: '#182028',
        hAxis: {
          title: 'Ano',
          minValue: '2004',
          maxValue: '2007',
          textStyle: {
            color: '#ffffff'
          }
        },
        vAxis: {
          title: '',
          minValue: 300,
          maxValue: 1200,
          textStyle: {
            color: '#ffffff'
          }
        }
      }
    }
  }
}
