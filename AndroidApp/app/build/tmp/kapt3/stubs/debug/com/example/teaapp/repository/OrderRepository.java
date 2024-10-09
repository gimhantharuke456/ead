package com.example.teaapp.repository;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\b\u0003\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004J*\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\n\u001a\u00020\u000bH\u0086@\u00f8\u0001\u0000\u00f8\u0001\u0001\u00f8\u0001\u0002\u00f8\u0001\u0002\u00a2\u0006\u0004\b\f\u0010\rJ\b\u0010\u000e\u001a\u00020\u000fH\u0002J(\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\u00110\bH\u0086@\u00f8\u0001\u0000\u00f8\u0001\u0001\u00f8\u0001\u0002\u00f8\u0001\u0002\u00a2\u0006\u0004\b\u0012\u0010\u0013R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004\u00a2\u0006\u0002\n\u0000\u0082\u0002\u000f\n\u0002\b!\n\u0005\b\u00a1\u001e0\u0001\n\u0002\b\u0019\u00a8\u0006\u0014"}, d2 = {"Lcom/example/teaapp/repository/OrderRepository;", "", "localPrefsService", "Lcom/example/teaapp/service/LocalPrefsService;", "(Lcom/example/teaapp/service/LocalPrefsService;)V", "apiService", "Lcom/example/teaapp/service/ApiService;", "createOrder", "Lkotlin/Result;", "Lcom/example/teaapp/dto/OrderResponse;", "orderRequest", "Lcom/example/teaapp/dto/CreateOrderRequest;", "createOrder-gIAlu-s", "(Lcom/example/teaapp/dto/CreateOrderRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "getBearerToken", "", "getOrders", "", "getOrders-IoAF18A", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "app_debug"})
public final class OrderRepository {
    @org.jetbrains.annotations.NotNull
    private final com.example.teaapp.service.LocalPrefsService localPrefsService = null;
    @org.jetbrains.annotations.NotNull
    private final com.example.teaapp.service.ApiService apiService = null;
    
    public OrderRepository(@org.jetbrains.annotations.NotNull
    com.example.teaapp.service.LocalPrefsService localPrefsService) {
        super();
    }
    
    private final java.lang.String getBearerToken() {
        return null;
    }
}