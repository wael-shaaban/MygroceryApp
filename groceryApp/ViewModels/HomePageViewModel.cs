﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using groceryApp.Models;
using groceryApp.Services;
using System.Collections.ObjectModel;

namespace groceryApp.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly CategoryService categoryService;
        private readonly OfferService offerService;
        [ObservableProperty]
        ObservableCollection<CategoryModel> categories;

        [ObservableProperty]
        ObservableCollection<OfferModel> offers;

        public HomePageViewModel(CategoryService categoryService, OfferService offerService)
        {
            this.categoryService = categoryService;
            this.offerService = offerService;
            Categories = new ObservableCollection<CategoryModel>();
            Offers = new ObservableCollection<OfferModel>();
        }
        [RelayCommand]
        public async Task InitializeAsync()
        {
            var offerTask = offerService.GetOffersAsync();
            foreach (var category in await categoryService.GetCategoriesAsync())
                Categories.Add(category);
            foreach (var offer in await offerTask)
                Offers.Add(offer);
        }
    }
}