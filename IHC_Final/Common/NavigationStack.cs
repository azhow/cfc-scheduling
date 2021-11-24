using IHC_Final.View;
using System.Collections.Generic;
using System.Windows.Controls;

namespace IHC_Final.Common
{
    public sealed class NavigationStack
    {
        private NavigationStack()
        {
            _navigationStack = new Stack<Page> { };
        }

        private static NavigationStack _instance;

        public static NavigationStack Instance
        {
            get { return _instance ?? (_instance = new NavigationStack()); }
        }

        private Stack<Page> _navigationStack;

        public Page NextPage { 
            get
            {
                if (_navigationStack.Count == 0)
                {
                    _navigationStack.Push(new OperationSelectionPage());
                }
                else
                {
                    switch (_navigationStack.Peek())
                    {
                        case OperationSelectionPage:
                            _navigationStack.Push(new CategorySelectionPage());
                            break;
                        case CategorySelectionPage:
                            _navigationStack.Push(new BookingPage());
                            break;
                        case BookingPage:
                            _navigationStack.Push(new ExtractPage());
                            break;
                        case ExtractPage:
                            break;
                        default:
                            break;
                    }
                }

                return _navigationStack.Peek();
            }
        }

        public Page CurrentPage { get => _navigationStack.Peek(); }

        public Page PreviousPage
        {
            get
            {
                _navigationStack.Pop();
                return _navigationStack.Peek();
            }
        }

        public Page StartPage
        {
            get
            {
                _navigationStack.Clear();
                _navigationStack.Push(new OperationSelectionPage());
                return CurrentPage;
            }
        }
    }
}
