using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF.Atividade3.Model;

namespace XF.Atividade3.ViewModel
{
    class AlunoViewModel
    {
        public AlunoViewModel()
        {
        }

        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public List<Aluno> Alunos
        {
            get
            {
                return App.AlunoModel.GetAlunos().ToList();
            }
        }
        #endregion
    }
}
