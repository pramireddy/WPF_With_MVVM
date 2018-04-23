using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab.KnowledgeShare.Wpf101.UI.Extensions
{
    public static class ListExtensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> collection)
        {
            var observableCollection = new ObservableCollection<T>();
            foreach (var e in collection)
            {
                observableCollection.Add(e);
            }
            return observableCollection;
        }
    }
}
