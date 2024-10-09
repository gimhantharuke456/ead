package com.example.teaapp;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u0017B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004\u00a2\u0006\u0002\u0010\u0006J\b\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u00022\u0006\u0010\u000e\u001a\u00020\u000bH\u0016J\u0018\u0010\u000f\u001a\u00020\u00022\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u000bH\u0016J\u001a\u0010\u0013\u001a\u00020\t2\u0012\u0010\u0014\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\t0\bJ\u0014\u0010\u0015\u001a\u00020\t2\f\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004R\u001a\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\t0\bX\u0082.\u00a2\u0006\u0002\n\u0000R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u000e\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u0018"}, d2 = {"Lcom/example/teaapp/OrderAdapter;", "Landroidx/recyclerview/widget/RecyclerView$Adapter;", "Lcom/example/teaapp/OrderAdapter$OrderViewHolder;", "orders", "", "Lcom/example/teaapp/dto/OrderResponse;", "(Ljava/util/List;)V", "onReviewClick", "Lkotlin/Function1;", "", "getItemCount", "", "onBindViewHolder", "holder", "position", "onCreateViewHolder", "parent", "Landroid/view/ViewGroup;", "viewType", "setOnReviewClickListener", "listener", "updateOrders", "newOrders", "OrderViewHolder", "app_debug"})
public final class OrderAdapter extends androidx.recyclerview.widget.RecyclerView.Adapter<com.example.teaapp.OrderAdapter.OrderViewHolder> {
    @org.jetbrains.annotations.NotNull
    private java.util.List<com.example.teaapp.dto.OrderResponse> orders;
    private kotlin.jvm.functions.Function1<? super com.example.teaapp.dto.OrderResponse, kotlin.Unit> onReviewClick;
    
    public OrderAdapter(@org.jetbrains.annotations.NotNull
    java.util.List<com.example.teaapp.dto.OrderResponse> orders) {
        super();
    }
    
    @java.lang.Override
    @org.jetbrains.annotations.NotNull
    public com.example.teaapp.OrderAdapter.OrderViewHolder onCreateViewHolder(@org.jetbrains.annotations.NotNull
    android.view.ViewGroup parent, int viewType) {
        return null;
    }
    
    @java.lang.Override
    public void onBindViewHolder(@org.jetbrains.annotations.NotNull
    com.example.teaapp.OrderAdapter.OrderViewHolder holder, int position) {
    }
    
    @java.lang.Override
    public int getItemCount() {
        return 0;
    }
    
    public final void updateOrders(@org.jetbrains.annotations.NotNull
    java.util.List<com.example.teaapp.dto.OrderResponse> newOrders) {
    }
    
    public final void setOnReviewClickListener(@org.jetbrains.annotations.NotNull
    kotlin.jvm.functions.Function1<? super com.example.teaapp.dto.OrderResponse, kotlin.Unit> listener) {
    }
    
    @kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004R\u0011\u0010\u0005\u001a\u00020\u0006\u00a2\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\t\u001a\u00020\u0006\u00a2\u0006\b\n\u0000\u001a\u0004\b\n\u0010\bR\u0011\u0010\u000b\u001a\u00020\u0006\u00a2\u0006\b\n\u0000\u001a\u0004\b\f\u0010\bR\u0011\u0010\r\u001a\u00020\u0006\u00a2\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\bR\u0011\u0010\u000f\u001a\u00020\u0006\u00a2\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\b\u00a8\u0006\u0011"}, d2 = {"Lcom/example/teaapp/OrderAdapter$OrderViewHolder;", "Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "view", "Landroid/view/View;", "(Landroid/view/View;)V", "itemName", "Landroid/widget/TextView;", "getItemName", "()Landroid/widget/TextView;", "orderDetails", "getOrderDetails", "orderId", "getOrderId", "orderStatus", "getOrderStatus", "shopName", "getShopName", "app_debug"})
    public static final class OrderViewHolder extends androidx.recyclerview.widget.RecyclerView.ViewHolder {
        @org.jetbrains.annotations.NotNull
        private final android.widget.TextView orderId = null;
        @org.jetbrains.annotations.NotNull
        private final android.widget.TextView shopName = null;
        @org.jetbrains.annotations.NotNull
        private final android.widget.TextView itemName = null;
        @org.jetbrains.annotations.NotNull
        private final android.widget.TextView orderStatus = null;
        @org.jetbrains.annotations.NotNull
        private final android.widget.TextView orderDetails = null;
        
        public OrderViewHolder(@org.jetbrains.annotations.NotNull
        android.view.View view) {
            super(null);
        }
        
        @org.jetbrains.annotations.NotNull
        public final android.widget.TextView getOrderId() {
            return null;
        }
        
        @org.jetbrains.annotations.NotNull
        public final android.widget.TextView getShopName() {
            return null;
        }
        
        @org.jetbrains.annotations.NotNull
        public final android.widget.TextView getItemName() {
            return null;
        }
        
        @org.jetbrains.annotations.NotNull
        public final android.widget.TextView getOrderStatus() {
            return null;
        }
        
        @org.jetbrains.annotations.NotNull
        public final android.widget.TextView getOrderDetails() {
            return null;
        }
    }
}