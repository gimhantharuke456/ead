package com.example.teaapp.viewmodel;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001:\u0001\u0012B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004J.\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00020\u0010J\u000e\u0010\u0011\u001a\u00020\b2\u0006\u0010\u000f\u001a\u00020\u0010R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u0013"}, d2 = {"Lcom/example/teaapp/viewmodel/OrderViewModel;", "Landroidx/lifecycle/ViewModel;", "localPrefsService", "Lcom/example/teaapp/service/LocalPrefsService;", "(Lcom/example/teaapp/service/LocalPrefsService;)V", "orderRepository", "Lcom/example/teaapp/repository/OrderRepository;", "createOrder", "", "shopItemId", "", "shopId", "quantity", "", "address", "callback", "Lcom/example/teaapp/viewmodel/OrderViewModel$OrderCallback;", "getOrders", "OrderCallback", "app_debug"})
public final class OrderViewModel extends androidx.lifecycle.ViewModel {
    @org.jetbrains.annotations.NotNull
    private final com.example.teaapp.service.LocalPrefsService localPrefsService = null;
    @org.jetbrains.annotations.NotNull
    private final com.example.teaapp.repository.OrderRepository orderRepository = null;
    
    public OrderViewModel(@org.jetbrains.annotations.NotNull
    com.example.teaapp.service.LocalPrefsService localPrefsService) {
        super();
    }
    
    public final void createOrder(@org.jetbrains.annotations.NotNull
    java.lang.String shopItemId, @org.jetbrains.annotations.NotNull
    java.lang.String shopId, int quantity, @org.jetbrains.annotations.NotNull
    java.lang.String address, @org.jetbrains.annotations.NotNull
    com.example.teaapp.viewmodel.OrderViewModel.OrderCallback callback) {
    }
    
    public final void getOrders(@org.jetbrains.annotations.NotNull
    com.example.teaapp.viewmodel.OrderViewModel.OrderCallback callback) {
    }
    
    @kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0016\u0010\u0006\u001a\u00020\u00032\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bH&J\u0010\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&\u00a8\u0006\u000b"}, d2 = {"Lcom/example/teaapp/viewmodel/OrderViewModel$OrderCallback;", "", "onError", "", "message", "", "onOrdersFetched", "orders", "", "Lcom/example/teaapp/dto/OrderResponse;", "onSuccess", "app_debug"})
    public static abstract interface OrderCallback {
        
        public abstract void onSuccess(@org.jetbrains.annotations.NotNull
        java.lang.String message);
        
        public abstract void onError(@org.jetbrains.annotations.NotNull
        java.lang.String message);
        
        public abstract void onOrdersFetched(@org.jetbrains.annotations.NotNull
        java.util.List<com.example.teaapp.dto.OrderResponse> orders);
    }
}