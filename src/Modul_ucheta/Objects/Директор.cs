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
    /// Директор.
    /// </summary>
    // *** Start programmer edit section *** (Директор CustomAttributes)

    // *** End programmer edit section *** (Директор CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДиректорE", new string[] {
            "idДиректора as \'Id директора\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "НомерТелефона as \'Номер телефона\'",
            "НомерПаспорта as \'Номер паспорта\'",
            "СерияПаспорта as \'Серия паспорта\'"})]
    [View("ДиректорL", new string[] {
            "idДиректора as \'Id директора\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "НомерТелефона as \'Номер телефона\'",
            "НомерПаспорта as \'Номер паспорта\'",
            "СерияПаспорта as \'Серия паспорта\'"})]
    public class Директор : ICSSoft.STORMNET.DataObject
    {
        
        private int fidДиректора;
        
        private string fФамилия;
        
        private string fИмя;
        
        private string fОтчество;
        
        private string fНомерТелефона;
        
        private int fНомерПаспорта;
        
        private int fСерияПаспорта;
        
        // *** Start programmer edit section *** (Директор CustomMembers)

        // *** End programmer edit section *** (Директор CustomMembers)

        
        /// <summary>
        /// idДиректора.
        /// </summary>
        // *** Start programmer edit section *** (Директор.idДиректора CustomAttributes)

        // *** End programmer edit section *** (Директор.idДиректора CustomAttributes)
        public virtual int idДиректора
        {
            get
            {
                // *** Start programmer edit section *** (Директор.idДиректора Get start)

                // *** End programmer edit section *** (Директор.idДиректора Get start)
                int result = this.fidДиректора;
                // *** Start programmer edit section *** (Директор.idДиректора Get end)

                // *** End programmer edit section *** (Директор.idДиректора Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.idДиректора Set start)

                // *** End programmer edit section *** (Директор.idДиректора Set start)
                this.fidДиректора = value;
                // *** Start programmer edit section *** (Директор.idДиректора Set end)

                // *** End programmer edit section *** (Директор.idДиректора Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Директор.Имя CustomAttributes)

        // *** End programmer edit section *** (Директор.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Директор.Имя Get start)

                // *** End programmer edit section *** (Директор.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Директор.Имя Get end)

                // *** End programmer edit section *** (Директор.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.Имя Set start)

                // *** End programmer edit section *** (Директор.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Директор.Имя Set end)

                // *** End programmer edit section *** (Директор.Имя Set end)
            }
        }
        
        /// <summary>
        /// НомерПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (Директор.НомерПаспорта CustomAttributes)

        // *** End programmer edit section *** (Директор.НомерПаспорта CustomAttributes)
        public virtual int НомерПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (Директор.НомерПаспорта Get start)

                // *** End programmer edit section *** (Директор.НомерПаспорта Get start)
                int result = this.fНомерПаспорта;
                // *** Start programmer edit section *** (Директор.НомерПаспорта Get end)

                // *** End programmer edit section *** (Директор.НомерПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.НомерПаспорта Set start)

                // *** End programmer edit section *** (Директор.НомерПаспорта Set start)
                this.fНомерПаспорта = value;
                // *** Start programmer edit section *** (Директор.НомерПаспорта Set end)

                // *** End programmer edit section *** (Директор.НомерПаспорта Set end)
            }
        }
        
        /// <summary>
        /// НомерТелефона.
        /// </summary>
        // *** Start programmer edit section *** (Директор.НомерТелефона CustomAttributes)

        // *** End programmer edit section *** (Директор.НомерТелефона CustomAttributes)
        [StrLen(255)]
        public virtual string НомерТелефона
        {
            get
            {
                // *** Start programmer edit section *** (Директор.НомерТелефона Get start)

                // *** End programmer edit section *** (Директор.НомерТелефона Get start)
                string result = this.fНомерТелефона;
                // *** Start programmer edit section *** (Директор.НомерТелефона Get end)

                // *** End programmer edit section *** (Директор.НомерТелефона Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.НомерТелефона Set start)

                // *** End programmer edit section *** (Директор.НомерТелефона Set start)
                this.fНомерТелефона = value;
                // *** Start programmer edit section *** (Директор.НомерТелефона Set end)

                // *** End programmer edit section *** (Директор.НомерТелефона Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Директор.Отчество CustomAttributes)

        // *** End programmer edit section *** (Директор.Отчество CustomAttributes)
        [StrLen(255)]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Директор.Отчество Get start)

                // *** End programmer edit section *** (Директор.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Директор.Отчество Get end)

                // *** End programmer edit section *** (Директор.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.Отчество Set start)

                // *** End programmer edit section *** (Директор.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Директор.Отчество Set end)

                // *** End programmer edit section *** (Директор.Отчество Set end)
            }
        }
        
        /// <summary>
        /// СерияПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (Директор.СерияПаспорта CustomAttributes)

        // *** End programmer edit section *** (Директор.СерияПаспорта CustomAttributes)
        public virtual int СерияПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (Директор.СерияПаспорта Get start)

                // *** End programmer edit section *** (Директор.СерияПаспорта Get start)
                int result = this.fСерияПаспорта;
                // *** Start programmer edit section *** (Директор.СерияПаспорта Get end)

                // *** End programmer edit section *** (Директор.СерияПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.СерияПаспорта Set start)

                // *** End programmer edit section *** (Директор.СерияПаспорта Set start)
                this.fСерияПаспорта = value;
                // *** Start programmer edit section *** (Директор.СерияПаспорта Set end)

                // *** End programmer edit section *** (Директор.СерияПаспорта Set end)
            }
        }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Директор.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Директор.Фамилия CustomAttributes)
        [StrLen(255)]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Директор.Фамилия Get start)

                // *** End programmer edit section *** (Директор.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Директор.Фамилия Get end)

                // *** End programmer edit section *** (Директор.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Директор.Фамилия Set start)

                // *** End programmer edit section *** (Директор.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Директор.Фамилия Set end)

                // *** End programmer edit section *** (Директор.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДиректорE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДиректорE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДиректорE", typeof(IIS.Modul_ucheta.Директор));
                }
            }
            
            /// <summary>
            /// "ДиректорL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДиректорL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДиректорL", typeof(IIS.Modul_ucheta.Директор));
                }
            }
        }
    }
}
