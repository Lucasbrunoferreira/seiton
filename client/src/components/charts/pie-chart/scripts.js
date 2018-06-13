export default {
  data () {
    return {
      columns: [{
        'type': 'string',
        'label': 'Produto'
      }, {
        'type': 'number',
        'label': '.'
      }, {
        'type': 'number',
        'label': 'Total'
      }],
      rows: [
        ['Normal', 5, 5],
        ['Atenção ', 3, 3],
        ['Crítico', 2, 2]
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
        title: 'Situação do Estoque',
        colors: ['#44c0b8'],
        backgroundColor: '#182028',
        hAxis: {
          title: '',
          minValue: 1,
          maxValue: 10,
          textStyle: {
            color: '#ffffff'
          }
        },
        vAxis: {
          title: '',
          minValue: 1,
          maxValue: 20,
          textStyle: {
            color: '#ffffff'
          }
        }
      }
    }
  }
}
