'use client'

import { useState } from 'react'
import { Home, User } from '@tamagui/lucide-icons'
import { XStack, YStack, getTokens, styled, Text } from 'tamagui'

const TabBar = styled(XStack, {
  backgroundColor: 'white',
  borderTopWidth: 1,
  borderColor: '#eee',
  height: 60,
  paddingBottom: 5,
})

const TabButton = styled(YStack, {
  flex: 1,
  alignItems: 'center',
  justifyContent: 'center',
  paddingTop: 8,
  variants: {
    active: {
      true: {
        color: '$blue10',
      },
      false: {
        color: '$gray10',
      },
    },
  } as const,
})

const TabText = styled(Text, {
  marginTop: 4,
  fontSize: 12,
  variants: {
    active: {
      true: {
        color: '$blue10',
      },
      false: {
        color: '$gray10',
      },
    },
  } as const,
})

export const MainBottomTabs = () => {
  const [activeTab, setActiveTab] = useState('home')
  const tokens = getTokens()

  const tabs = [
    {
      key: 'home',
      label: 'Home',
      icon: Home,
    },
    {
      key: 'profile',
      label: 'Profile',
      icon: User,
    },
  ]

  return (
    <>
      <TabBar width={'100%'} $gtXs={{ display: 'none' }} />
      <TabBar
        position="absolute"
        bottom={0}
        left={0}
        width={'100%'}
        zIndex={tokens.zIndex[1]}
        $gtXs={{ display: 'none' }}
      >
        {tabs.map((tab) => {
          const isActive = activeTab === tab.key
          const IconComponent = tab.icon
          const color = isActive ? tokens.color.blue10Light.val : tokens.color.gray10Light.val
          return (
            <TabButton
              key={tab.key}
              active={isActive}
              onPress={() => setActiveTab(tab.key)}
              cursor="pointer"
            >
              <IconComponent size={24} color={color as any} />
              <TabText active={isActive}>{tab.label}</TabText>
            </TabButton>
          )
        })}
      </TabBar>
    </>
  )
}
