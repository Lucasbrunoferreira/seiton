export default {
  data () {
    return {
      columns: [{
        'type': 'string',
        'label': 'Produto'
      }, {
        'type': 'number',
        'label': 'Compra'
      }, {
        'type': 'number',
        'label': 'Venda'
      }],
      rows: [
        ['Losartana', 1000, 400],
        ['Diclofenaco', 1170, 460],
        ['Dipirona', 660, 1120],
        ['Captopril', 1030, 540]
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
        title: 'Compra/Venda Produto',
        colors: ['#6BD8D1', '#164d49'],
        backgroundColor: '#182028',
        hAxis: {
          title: 'Year',
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
