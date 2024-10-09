package com.example.teaapp;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u00012\u00020\u0002:\u0001\u0019B\u0005\u00a2\u0006\u0002\u0010\u0003J\b\u0010\n\u001a\u00020\u000bH\u0002J\u0012\u0010\f\u001a\u00020\u000b2\b\u0010\r\u001a\u0004\u0018\u00010\u000eH\u0014J\u0010\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0016\u0010\u0012\u001a\u00020\u000b2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00150\u0014H\u0016J\u0010\u0010\u0016\u001a\u00020\u000b2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0010\u0010\u0017\u001a\u00020\u000b2\u0006\u0010\u0018\u001a\u00020\u0015H\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082.\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u001a"}, d2 = {"Lcom/example/teaapp/MyOrderActivity;", "Landroidx/appcompat/app/AppCompatActivity;", "Lcom/example/teaapp/viewmodel/OrderViewModel$OrderCallback;", "()V", "orderAdapter", "Lcom/example/teaapp/OrderAdapter;", "orderViewModel", "Lcom/example/teaapp/viewmodel/OrderViewModel;", "recyclerView", "Landroidx/recyclerview/widget/RecyclerView;", "fetchOrders", "", "onCreate", "savedInstanceState", "Landroid/os/Bundle;", "onError", "message", "", "onOrdersFetched", "orders", "", "Lcom/example/teaapp/dto/OrderResponse;", "onSuccess", "showReviewDialog", "order", "OrderViewModelFactory", "app_debug"})
public final class MyOrderActivity extends androidx.appcompat.app.AppCompatActivity implements com.example.teaapp.viewmodel.OrderViewModel.OrderCallback {
    private com.example.teaapp.viewmodel.OrderViewModel orderViewModel;
    private androidx.recyclerview.widget.RecyclerView recyclerView;
    private com.example.teaapp.OrderAdapter orderAdapter;
    
    public MyOrderActivity() {
        super();
    }
    
    @java.lang.Override
    protected void onCreate(@org.jetbrains.annotations.Nullable
    android.os.Bundle savedInstanceState) {
    }
    
    private final void fetchOrders() {
    }
    
    @java.lang.Override
    public void onSuccess(@org.jetbrains.annotations.NotNull
    java.lang.String message) {
    }
    
    @java.lang.Override
    public void onError(@org.jetbrains.annotations.NotNull
    java.lang.String message) {
    }
    
    @java.lang.Override
    public void onOrdersFetched(@org.jetbrains.annotations.NotNull
    java.util.List<com.example.teaapp.dto.OrderResponse> orders) {
    }
    
    private final void showReviewDialog(com.example.teaapp.dto.OrderResponse order) {
    }
    
    @kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004J%\u0010\u0005\u001a\u0002H\u0006\"\b\b\u0000\u0010\u0006*\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00060\tH\u0016\u00a2\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u000b"}, d2 = {"Lcom/example/teaapp/MyOrderActivity$OrderViewModelFactory;", "Landroidx/lifecycle/ViewModelProvider$Factory;", "localPrefsService", "Lcom/example/teaapp/service/LocalPrefsService;", "(Lcom/example/teaapp/service/LocalPrefsService;)V", "create", "T", "Landroidx/lifecycle/ViewModel;", "modelClass", "Ljava/lang/Class;", "(Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", "app_debug"})
    public static final class OrderViewModelFactory implements androidx.lifecycle.ViewModelProvider.Factory {
        @org.jetbrains.annotations.NotNull
        private final com.example.teaapp.service.LocalPrefsService localPrefsService = null;
        
        public OrderViewModelFactory(@org.jetbrains.annotations.NotNull
        com.example.teaapp.service.LocalPrefsService localPrefsService) {
            super();
        }
        
        @java.lang.Override
        @org.jetbrains.annotations.NotNull
        public <T extends androidx.lifecycle.ViewModel>T create(@org.jetbrains.annotations.NotNull
        java.lang.Class<T> modelClass) {
            return null;
        }
    }
}