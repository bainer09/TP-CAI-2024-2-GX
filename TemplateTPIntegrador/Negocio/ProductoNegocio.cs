﻿using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Negocio
{
    public class ProductoNegocio
    {
        private int StockCritico = 10;
        private ProductoWS ProductoWS = new ProductoWS();
        private ProductoPersistente ProductoP = new ProductoPersistente();
        public void AltaProducto(AltaProducto producto)
        {            
            ProductoWS.AltaProducto(producto);

            Producto nuevoProducto = new Producto
            {
                _Nombre = producto._Nombre,
                _Precio = producto._Precio,
                _Stock = producto._Stock,
                _idCategoria = producto._idCategoria,
                _idProveedor = producto._idProveedor,
                _FechaAlta = DateTime.Now,
                _FechaBaja = null
            };
            ProductoP.AltaProductoLocal(nuevoProducto);
        }
        public void ModificarProducto(string idProducto, string idUsuario, double precio, int stock)
        {
            ModificarProducto productoModificado = new ModificarProducto(idProducto, idUsuario, precio, stock);
            ProductoWS.ModificarProducto(productoModificado);
            ProductoP.ModificarProductoLocal(idProducto, precio, stock);
        }
        public void BajaProducto(string idProducto, string idUsuario, string nombreProducto)
        {
            BajaProducto productoBaja = new BajaProducto(idProducto, idUsuario);
            ProductoWS.BajaProducto(productoBaja);
            ProductoP.BajaProductoLocal(nombreProducto);
        }
        public List<Producto> ObtenerProductos()
        {
            return ProductoWS.GetProductos();
        }
        public void ReactivarProducto(string idProducto, string idUsuario, string nombreProducto)
        {
            ReactivarProducto productoReactivado = new ReactivarProducto(idProducto, idUsuario);

            ProductoWS.ReactivarProducto(productoReactivado);
            ProductoP.ReactivarProductoLocal(nombreProducto);
        }
        public int ProductosConStockCritico()
        {
            List<Producto> productos = ObtenerProductos();
            return productos.Count(p => p._Stock <= StockCritico);
        }
        public List<Producto> ObtenerProductosConStockCritico()
        {
            List<Producto> productos = ObtenerProductos();
            return productos.Where(p => p._Stock <= StockCritico).ToList();
        }
        public List<Producto> ObtenerProductosDadosDeBaja()
        {
            return ProductoWS.GetProductosDadosDeBaja();
        }
        public List<Producto> ObtenerProductosPorCategoria(int categoria)
        {
            return ProductoWS.GetProductosporCategoria(categoria);
        }
    }
}