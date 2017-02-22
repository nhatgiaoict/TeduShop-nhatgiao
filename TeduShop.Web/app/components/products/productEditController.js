(function (app) {
    app.controller('productEditController', productEditController);

    productEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService','$stateParams'];
    function productEditController(apiService, $scope, notificationService, $state, commonService, $stateParams) {
        $scope.product = {};

        $scope.ckeditorOptions = {
            languague: 'vi',
            height: '200px'
        }

        $scope.productCategories = [];
        $scope.moreImages = [];

        $scope.updateProduct = updateProduct;
        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.ShortLink = commonService.getSeoTitle($scope.product.Title);
        }

        function updateProduct() {
            $scope.product.MoreImages = JSON.stringify($scope.moreImages);
            apiService.put('/api/product/update', $scope.product, function (result) {
                notificationService.displaySuccess(result.data.Title + ' Đã được cập nhật thành công');
                $state.go('products');
            }, function (error) {
                notificationService.displayError('Cập nhật không thành công');
            });
        }
        function loadProductDetail() {
            apiService.get('/api/product/getbyid/' + $stateParams.id, null, function (result) {
                $scope.product = result.data;
                $scope.moreImages = JSON.parse($scope.product.MoreImages);
            }, function (error) {
                notificationService.displayError(error.data);
            });
        }
        function loadProductCategory() {
            apiService.get('/api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list product category');
            });
        }
        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.product.Fimages = fileUrl;
                })
            }
            finder.popup();
        }
        $scope.ChooseMoreImages = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.moreImages.push(fileUrl);
                })
            }
            finder.popup();
        }
        loadProductDetail();
        loadProductCategory();
    }
})(angular.module('tedushop.products'));