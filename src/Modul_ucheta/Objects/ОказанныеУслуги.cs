﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Modul_ucheta
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Оказанные услуги.
    /// </summary>
    // *** Start programmer edit section *** (ОказанныеУслуги CustomAttributes)

    // *** End programmer edit section *** (ОказанныеУслуги CustomAttributes)
    [AutoAltered()]
    [Caption("Оказанные услуги")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОказанныеУслугиE", new string[] {
            "Дата as \'Дата\'",
            "Услуги as \'Наименование\'",
            "Услуги.ЗатрачВремя as \'Затраченное время\'",
            "Услуги.ЕдиницаВремени as \'Единица времени\'"})]
    [MasterViewDefineAttribute("ОказанныеУслугиE", "Услуги", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class ОказанныеУслуги : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private IIS.Modul_ucheta.Услуги fУслуги;
        
        private IIS.Modul_ucheta.РасчетВремени fРасчетВремени;
        
        // *** Start programmer edit section *** (ОказанныеУслуги CustomMembers)

        // *** End programmer edit section *** (ОказанныеУслуги CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ОказанныеУслуги.Дата CustomAttributes)

        // *** End programmer edit section *** (ОказанныеУслуги.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ОказанныеУслуги.Дата Get start)

                // *** End programmer edit section *** (ОказанныеУслуги.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ОказанныеУслуги.Дата Get end)

                // *** End programmer edit section *** (ОказанныеУслуги.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОказанныеУслуги.Дата Set start)

                // *** End programmer edit section *** (ОказанныеУслуги.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ОказанныеУслуги.Дата Set end)

                // *** End programmer edit section *** (ОказанныеУслуги.Дата Set end)
            }
        }
        
        /// <summary>
        /// Оказанные услуги.
        /// </summary>
        // *** Start programmer edit section *** (ОказанныеУслуги.Услуги CustomAttributes)

        // *** End programmer edit section *** (ОказанныеУслуги.Услуги CustomAttributes)
        [PropertyStorage(new string[] {
                "Услуги"})]
        [NotNull()]
        public virtual IIS.Modul_ucheta.Услуги Услуги
        {
            get
            {
                // *** Start programmer edit section *** (ОказанныеУслуги.Услуги Get start)

                // *** End programmer edit section *** (ОказанныеУслуги.Услуги Get start)
                IIS.Modul_ucheta.Услуги result = this.fУслуги;
                // *** Start programmer edit section *** (ОказанныеУслуги.Услуги Get end)

                // *** End programmer edit section *** (ОказанныеУслуги.Услуги Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОказанныеУслуги.Услуги Set start)

                // *** End programmer edit section *** (ОказанныеУслуги.Услуги Set start)
                this.fУслуги = value;
                // *** Start programmer edit section *** (ОказанныеУслуги.Услуги Set end)

                // *** End programmer edit section *** (ОказанныеУслуги.Услуги Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Modul_ucheta.РасчетВремени.
        /// </summary>
        // *** Start programmer edit section *** (ОказанныеУслуги.РасчетВремени CustomAttributes)

        // *** End programmer edit section *** (ОказанныеУслуги.РасчетВремени CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "РасчетВремени"})]
        public virtual IIS.Modul_ucheta.РасчетВремени РасчетВремени
        {
            get
            {
                // *** Start programmer edit section *** (ОказанныеУслуги.РасчетВремени Get start)

                // *** End programmer edit section *** (ОказанныеУслуги.РасчетВремени Get start)
                IIS.Modul_ucheta.РасчетВремени result = this.fРасчетВремени;
                // *** Start programmer edit section *** (ОказанныеУслуги.РасчетВремени Get end)

                // *** End programmer edit section *** (ОказанныеУслуги.РасчетВремени Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОказанныеУслуги.РасчетВремени Set start)

                // *** End programmer edit section *** (ОказанныеУслуги.РасчетВремени Set start)
                this.fРасчетВремени = value;
                // *** Start programmer edit section *** (ОказанныеУслуги.РасчетВремени Set end)

                // *** End programmer edit section *** (ОказанныеУслуги.РасчетВремени Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОказанныеУслугиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОказанныеУслугиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОказанныеУслугиE", typeof(IIS.Modul_ucheta.ОказанныеУслуги));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ОказанныеУслуги.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfОказанныеУслуги CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfОказанныеУслуги CustomAttributes)
    public class DetailArrayOfОказанныеУслуги : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Modul_ucheta.DetailArrayOfОказанныеУслуги members)

        // *** End programmer edit section *** (IIS.Modul_ucheta.DetailArrayOfОказанныеУслуги members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ОказанныеУслуги by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ОказанныеУслуги.
        /// </summary>
        public DetailArrayOfОказанныеУслуги(IIS.Modul_ucheta.РасчетВремени fРасчетВремени) : 
                base(typeof(ОказанныеУслуги), ((ICSSoft.STORMNET.DataObject)(fРасчетВремени)))
        {
        }
        
        public IIS.Modul_ucheta.ОказанныеУслуги this[int index]
        {
            get
            {
                return ((IIS.Modul_ucheta.ОказанныеУслуги)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Modul_ucheta.ОказанныеУслуги dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
