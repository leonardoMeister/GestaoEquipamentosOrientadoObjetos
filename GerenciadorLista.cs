using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentosOO
{
    class GerenciadorLista
    {

        Equipamentos[] listaEquipamentoTotal = new Equipamentos[100];
        Chamados[] listaChamadosTotal = new Chamados[100];
        private int auxChamados = 1;
        private int auxEquipamentos = 1;



        public void RemoverChamado(String titulo, int idChamado)
        {
            for (int i = 0; i < auxChamados; i++)
            {
                if (listaChamadosTotal[i] == null)
                {
                    continue;
                }
                else
                {
                    try
                    {
                        if (listaChamadosTotal[i].Titulo == titulo && listaChamadosTotal[i].Id_chamado == idChamado)     //usar Try, quando ele chega em um valor nullo a comparação da erro
                        {
                            listaChamadosTotal[i] = null;
                            auxChamados--;
                            return;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        public void MostrarChamados()
        {
            for (int i = 0; i < auxChamados; i++)
            {
                if (listaChamadosTotal[i] != null)
                {
                    Console.WriteLine(listaChamadosTotal[i].ToString());
                }
            }
        }
        public void AdicionarChamado(Chamados chamado)
        {
            for (int i = 0; i < auxChamados; i++)
            {
                if (listaChamadosTotal[i] == null)
                {
                    listaChamadosTotal[i] = chamado;
                    auxChamados++;
                    return;
                }
            }
        }
        public Chamados SelecionarChamado(string titulo, int idChamado)
        {
            for (int i = 0; i < auxChamados; i++)
            {
                try
                {
                    if (listaChamadosTotal[i].Titulo == titulo && listaChamadosTotal[i].Id_chamado == idChamado)
                    {
                        return listaChamadosTotal[i];
                    }
                    else if (listaChamadosTotal[i] == null) continue;
                }
                catch (Exception)
                {

                }
            }
            return null;
        }
        public void EditarChamado(string titulo, int idChamado)
        {

        }
        //--------------------------------------------------------------------------------------------------------------------
        public void EditarEquipamento(string nome, int idEquipamento)
        {

        }

        public Equipamentos SelecionarEquipamento(string nome, int idEquipamento)
        {
            for (int i = 0; i < auxEquipamentos; i++)
            {
                try
                {
                    if (listaEquipamentoTotal[i].Nome == nome && listaEquipamentoTotal[i].Id_equipamento == idEquipamento)
                    {
                        return listaEquipamentoTotal[i];
                    }
                    else if (listaEquipamentoTotal[i] == null) continue;
                }
                catch (Exception)
                {

                }
            }
            return null;
        }
        public void AdicionarEquipamento(Equipamentos equipamento)
        {
            for (int i = 0; i < auxEquipamentos; i++)
            {
                if (listaEquipamentoTotal[i] == null)
                {
                    listaEquipamentoTotal[i] = equipamento;
                    auxEquipamentos++;
                    return;
                }
            }
        }
        public void MostrarEquipamentos()
        {
            for (int i = 0; i < auxEquipamentos; i++)
            {
                if (listaEquipamentoTotal[i] != null)
                {
                    Console.WriteLine(listaEquipamentoTotal[i].ToString());
                }
            }
        }
        public void RemoverEquipamento(String nome, int id)
        {
            for (int i = 0; i < auxEquipamentos; i++)
            {
                if (listaEquipamentoTotal[i] == null)
                {
                    continue;
                }
                else
                {
                    try
                    {
                        if (listaEquipamentoTotal[i].Nome == nome && listaEquipamentoTotal[i].Id_equipamento == id)     //usar Try, quando ele chega em um valor nullo a comparação da erro
                        {
                            listaEquipamentoTotal[i] = null;
                            auxEquipamentos--;
                            return;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }



    }
}
