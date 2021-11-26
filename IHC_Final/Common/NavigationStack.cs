using IHC_Final.View;
using System;
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
                    switch (CurrentPage)
                    {
                        case OperationSelectionPage:
                            switch ((CurrentPage as OperationSelectionPage).ViewModel.OperationIndex)
                            {
                                case 0:
                                    _navigationStack.Push(new CategorySelectionPage());
                                    break;
                                case 1:
                                    _navigationStack.Push(new ExtractPage(false));
                                    break;
                                default:
                                    throw new Exception("Operação inválida selecionada");
                            }
                            break;
                        case CategorySelectionPage:
                            _navigationStack.Push(new BookingPage());
                            break;
                        case BookingPage:
                            _navigationStack.Push(new ExtractPage(true));
                            break;
                        case ExtractPage:
                            if ((CurrentPage as ExtractPage).FromSchedule)
                                _navigationStack.Push(new OperationResultPage());
                            break;
                        default:
                            break;
                    }
                }

                return CurrentPage;
            }
        }

        public Page CurrentPage { get => _navigationStack.Peek(); }

        public Page PreviousPage
        {
            get
            {
                _navigationStack.Pop();
                return CurrentPage;
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
