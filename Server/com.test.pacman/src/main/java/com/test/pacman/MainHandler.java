package com.test.pacman;

import io.netty.channel.Channel;
import io.netty.channel.ChannelHandlerContext;
import io.netty.channel.ChannelInboundHandlerAdapter;

import java.util.ArrayList;
import java.util.List;

public class MainHandler extends ChannelInboundHandlerAdapter {
    private static final List<Channel> channels = new ArrayList<>();
    Manager manager = new Manager();

    @Override
    public void channelActive(ChannelHandlerContext ctx) throws Exception {
        System.out.println("Подключился: " + ctx);
        channels.add(ctx.channel());
        manager.CreateLevel();
        BroadcastMessageAtStart(ctx, manager.MapInfo(), manager.LevelInfo(), manager.curPosition);
    }
    @Override
    public void channelRead(ChannelHandlerContext ctx, Object obj) throws Exception {
        MessageProto.Request req = (MessageProto.Request) obj;
        System.out.println("Получил: " + req);

        Vector2 pos = manager.TransformPosition(req.getInputMsg());

        BroadcastMessage(ctx, pos, manager.speed);

    }
    public void BroadcastMessage(ChannelHandlerContext ctx, Vector2 pos, float speed){
        MessageProto.Response res = MessageProto.Response.newBuilder()
                .setResponseMsg(5)
                .addAllPositionMsg(CreateArrayFromVector(pos))
                .setSpeedMsg(speed).build();

        for(Channel c: channels) {
            c.writeAndFlush(res);
        }
        System.out.println("Отослал: " + res);
    }
    public void BroadcastMessageAtStart(ChannelHandlerContext ctx, Vector2 size, Vector2[] level, Vector2 curPos){
        ArrayList<Integer> masX = new ArrayList<>();
        ArrayList<Integer> masY = new ArrayList<>();
        for (Vector2 vector2 : level) {
            masX.add(vector2.x);
            masY.add(vector2.y);
        }
        MessageProto.Response res = MessageProto.Response.newBuilder()
                .addAllLevelSizeMsg(CreateArrayFromVector(size))
                .addAllWallMsgX(masX).addAllWallMsgY(masY)
                .addAllPositionMsg(CreateArrayFromVector(curPos)).build();

        for(Channel c: channels) {
            c.writeAndFlush(res);
        }
        System.out.println("Построение уровня и внесение стартовых координат");
    }
    ArrayList<Integer> CreateArrayFromVector(Vector2 vec){
        ArrayList<Integer> arr = new ArrayList<>();
        arr.add(vec.x);
        arr.add(vec.y);
        return arr;
    }
    @Override
    public void channelReadComplete(ChannelHandlerContext ctx) {
        ctx.flush();
    }

    @Override
    public void channelInactive(ChannelHandlerContext ctx) throws Exception {
        super.channelInactive(ctx);
        channels.remove(ctx.channel());
        System.out.println("Отключился: " + ctx);
    }

    @Override
    public void exceptionCaught(ChannelHandlerContext ctx, Throwable cause) throws Exception {
        cause.printStackTrace();
        ctx.close();
    }
}