using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWII6_TP02.Models;

namespace SWII6_TP02.DAO
{
    public class ContainerDAO
    {
        public void Adiciona(Container container)
        {
            using (var context = new PortoContext())
            {
                context.Containers.Add(container);
                context.SaveChanges();
            }
        }

        public IList<Container> Lista()
        {
            using (var context = new PortoContext())
            {
                return context.Containers.ToList();
            }
        }

        public Container BuscaPorNumero(int numero)
        {
            using (var context = new PortoContext())
            {
                return context.Containers.Find(numero);
            }
        }

        public void Atualiza(Container container)
        {
            using (var context = new PortoContext())
            {
                context.Entry(container).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}