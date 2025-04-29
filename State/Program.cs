/*Este tipo de padrão, de projeto adiciona estado ás classes e transita entre eles.
tornando até melhor o encapsulamento no código.*/
using State;

var pedido = new Pedido();
pedido.Expedido();
pedido.Recebido();
pedido.Finalizado();



