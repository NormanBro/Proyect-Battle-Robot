using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estados
{
    public int Brazo_IZQ=0;
    public int Brazo_DER=0;
    public int Cuerpo=0;

   public Estados(int Brazo_IZQ,int Brazo_DER,int Cuerpo)
   {
        this.Brazo_DER = Brazo_DER;
        this.Brazo_IZQ = Brazo_IZQ;
        this.Cuerpo = Cuerpo;
   }
    public Estados clone()
    {
        return new Estados(this.Brazo_IZQ, this.Brazo_DER, this.Cuerpo);
    }
}
