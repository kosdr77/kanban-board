﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace kanbanboard.Properties {
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("kanbanboard.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap _checked {
            get {
                object obj = ResourceManager.GetObject("_checked", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap check {
            get {
                object obj = ResourceManager.GetObject("check", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Byte[].
        /// </summary>
        internal static byte[] Roboto {
            get {
                object obj = ResourceManager.GetObject("Roboto", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap send_message {
            get {
                object obj = ResourceManager.GetObject("send_message", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static Bitmap user {
            get {
                object obj = ResourceManager.GetObject("user", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
    }
}
